using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusManagementSystem
{
    public partial class AddStudentForm : UserControl
    {

        public string connString = "Server=localhost;Database=campus;User ID=root;Password=12345;SslMode=none;";


        public AddStudentForm()
        {
            InitializeComponent();
            
            DisplaystudentData();


        }

        public void DisplaystudentData()
        {
            Addstudentsdata addSD = new Addstudentsdata();
            addSD.studentData();

            studentDgrid.DataSource = addSD.studentData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                MySqlConnection conn = new MySqlConnection(connString);

                if (txtSid.Text == "" ||
                    txtSname.Text == "" ||
                    txtSaddress.Text == "" ||
                    comSstatus.Text == "" ||
                    comSgender.Text == "" ||
                    comSgrade.Text == "" ||
                    comSsection.Text == "" ||
                    imgstudent.Image == null
                    )
                {
                    MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        try
                        {
                            conn.Open();

                            // Query to check if the teacher ID already exists
                            string checkstudentId = "SELECT * FROM students WHERE student_id = @studentId";

                            using (MySqlCommand CheckId = new MySqlCommand(checkstudentId, conn))
                            {
                                // Add parameter to prevent SQL injection
                                CheckId.Parameters.AddWithValue("@studentId", txtSid.Text.Trim());

                                MySqlDataAdapter cAdapter = new MySqlDataAdapter(CheckId);
                                DataTable cTable = new DataTable();
                                cAdapter.Fill(cTable);

                                // Check if any record exists
                                if (cTable.Rows.Count >= 1)
                                {
                                    MessageBox.Show("Student ID: " + txtSname.Text.Trim() + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                else
                                {
                                    DateTime today = DateTime.Today;

                                    string insertData = "INSERT INTO students" +
                                        "(student_id, student_name, student_gender, student_address, student_grade, student_section, student_image, student_status, date_insert)" +
                                        " VALUES(@studentId, @studentName, @studentGender, @studentAddress, @studentGrade, @studentSection, @studentImage, @studentStatus, @dateInsert)";

                                    //save image                     
                                    string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "student_images"); // Absolute Path
                                    string fileName = txtSid.Text.Trim() + ".jpg";
                                    string destinationPath = Path.Combine(folderPath, fileName);

                                    // Ensure directory exists
                                    if (!Directory.Exists(folderPath))
                                    {
                                        Directory.CreateDirectory(folderPath);
                                    }

                                    // Copy the file
                                    File.Copy(imagepath, destinationPath, true);


                                    using (MySqlCommand cmd = new MySqlCommand(insertData, conn))
                                    {
                                        cmd.Parameters.AddWithValue("@studentId", txtSid.Text.Trim());
                                        cmd.Parameters.AddWithValue("@studentName", txtSname.Text.Trim());
                                        cmd.Parameters.AddWithValue("@studentGender", comSgender.Text.Trim());
                                        cmd.Parameters.AddWithValue("@studentAddress", txtSaddress.Text.Trim());
                                        cmd.Parameters.AddWithValue("@studentImage", destinationPath);
                                        cmd.Parameters.AddWithValue("@studentGrade", comSgrade.Text.Trim());
                                        cmd.Parameters.AddWithValue("@studentSection", comSsection.Text.Trim());
                                        cmd.Parameters.AddWithValue("@studentStatus", comSstatus.Text.Trim());
                                        cmd.Parameters.AddWithValue("@dateInsert", today.ToString("yyyy-MM-dd"));

                                        cmd.ExecuteNonQuery();

                                        DisplaystudentData();

                                        MessageBox.Show("Ädded Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        clearFields();
                                    }
                                }
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Error connection Database:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
            }
        }


        public void clearFields()
        {
            txtSname.Text = "";
            txtSid.Text = "";
            txtSaddress.Text = "";
            comSgender.SelectedIndex = -1;
            comSstatus.SelectedIndex = -1;
            comSsection.SelectedIndex = -1;
            imgstudent.Image = null;
            comSgrade.SelectedIndex = -1;
            imagepath = "";
        }

        public String imagepath;

        private void btnimport_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg; *.png)|*.jpg;*.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                imagepath = open.FileName;
                imgstudent.ImageLocation = imagepath;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(connString);

            if (    txtSid.Text == "" ||
                    txtSname.Text == "" ||
                    txtSaddress.Text == "" ||
                    comSstatus.Text == "" ||
                    comSgender.Text == "" ||
                    comSgrade.Text == "" ||
                    comSsection.Text == "" ||
                    imgstudent.Image == null
                    )
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    DialogResult check = MessageBox.Show("Are you sure you want to update student ID: " + txtSid.Text.Trim() + "?",
                                                         "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE students SET  student_name = @studentName, student_gender = @studentGender, " +
                           "student_address = @studentAddress, student_grade = @studentGrade,  student_section = @studentSection, student_image = @studentImage, student_status = @studentStatus, " +
                           "date_update = @dateUpdate WHERE student_id = @studentID";

                        // Save image
                        string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "student_images");
                        string fileName = txtSid.Text.Trim() + ".jpg";
                        string destinationPath = Path.Combine(folderPath, fileName);

                        // Ensure directory exists
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }

                        // Copy the file only if the image path is valid
                        if (!string.IsNullOrEmpty(imagepath))
                        {
                            File.Copy(imagepath, destinationPath, true);
                        }


                        using (MySqlCommand cmd = new MySqlCommand(updateData, conn))
                        {
                            cmd.Parameters.AddWithValue("@studentID", txtSid.Text.Trim());
                            cmd.Parameters.AddWithValue("@studentName",txtSname.Text.Trim());
                            cmd.Parameters.AddWithValue("@studentGender", comSgender.Text.Trim());
                            cmd.Parameters.AddWithValue("@studentAddress", txtSaddress.Text.Trim());
                            cmd.Parameters.AddWithValue("@studentGrade", comSgrade.Text.Trim());
                            cmd.Parameters.AddWithValue("@studentSection",comSsection.Text.Trim());
                            cmd.Parameters.AddWithValue("@studentStatus", comSstatus.Text.Trim());
                            cmd.Parameters.AddWithValue("@studentImage", destinationPath);
                            cmd.Parameters.AddWithValue("@dateUpdate", today.ToString("yyyy-MM-dd")); // Fixed Date Format

                            cmd.ExecuteNonQuery();

                            DisplaystudentData();

                            MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields(); // Clear Fields After Update
                        }
                    }
                    else
                    {
                        MessageBox.Show("Update Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void studentDgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = studentDgrid.Rows[e.RowIndex];
                txtSid.Text = row.Cells[1].Value.ToString();
                txtSname.Text = row.Cells[2].Value.ToString();
                comSgender.Text = row.Cells[3].Value.ToString();
                txtSaddress.Text = row.Cells[4].Value.ToString();
                comSgrade.Text = row.Cells[5].Value.ToString();
                comSstatus.Text = row.Cells[6].Value.ToString();
                comSsection.Text = row.Cells[7].Value.ToString();
               

                // Load image correctly
                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "student_images", row.Cells[8].Value.ToString());

                if (File.Exists(imagePath))
                {
                    using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        imgstudent.Image = Image.FromStream(stream);
                    }
                }

                else
                {
                    imgstudent.Image = null; // Clear image if not found
                                             //  MessageBox.Show("Image not found: " + imagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;

            MySqlConnection conn = new MySqlConnection(connString);

            if (txtSid.Text == "")
            {
                MessageBox.Show("Please select item first", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to Delete Teacher ID: " + txtSid.Text + " ? ", "Confirmation Massage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            conn.Open();

                            string deleteData = "UPDATE students SET date_delete = @dateDelete WHERE student_id = @studentID";

                            using (MySqlCommand cmd = new MySqlCommand(deleteData, conn))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today.ToString("yyyy-MM-dd"));
                                cmd.Parameters.AddWithValue("@studentID", txtSid.Text.Trim().ToString());

                                cmd.ExecuteNonQuery();

                                DisplaystudentData();
                                MessageBox.Show("Deleted Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error connecting Database: " + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        finally
                        {
                            conn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelled", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}

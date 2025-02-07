using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.IO;

namespace CampusManagementSystem
{
    public partial class AddTeacherForm : UserControl
    {

        public string connString = "Server=localhost;Database=campus;User ID=root;Password=12345;SslMode=none;";

        public AddTeacherForm()
        {
            InitializeComponent();

            teacherDisplayData();
        }

        

        public void teacherDisplayData()
        {
            Addteacherdata addTD = new Addteacherdata();

            griddata_teacher.DataSource = addTD.teacherData();
        }

        private void btnteacher_add_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(connString);

            if (txtteacher_id.Text == "" ||
                txtteacher_name.Text == "" ||
                txtteacher_address.Text == "" ||
                comteacher_gender.Text == "" ||
                comteacher_status.Text == "" ||
                imgteacher.Image == null
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
                        string checkteacherId = "SELECT * FROM teachers WHERE teacher_id = @teacherId";

                        using (MySqlCommand CheckId = new MySqlCommand(checkteacherId, conn))
                        {
                            // Add parameter to prevent SQL injection
                            CheckId.Parameters.AddWithValue("@teacherId", txtteacher_id.Text.Trim());

                            MySqlDataAdapter cAdapter = new MySqlDataAdapter(CheckId);
                            DataTable cTable = new DataTable();
                            cAdapter.Fill(cTable);

                            // Check if any record exists
                            if (cTable.Rows.Count >= 1)
                            {
                                MessageBox.Show("Teacher ID: " + txtteacher_id.Text.Trim() + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO teachers" +
                                    "(teacher_id, teacher_name, teacher_gender, teacher_address, teacher_image, teacher_status, date_insert)" +
                                    " VALUES(@teacherId, @teacherName, @teacherGender, @teacherAddress, @teacherImage, @teacherStatus, @dateInsert)";

                                //save image                     
                                string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "teacher images"); // Absolute Path
                                string fileName = txtteacher_id.Text.Trim() + ".jpg";
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
                                    cmd.Parameters.AddWithValue("@teacherId", txtteacher_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherName", txtteacher_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherGender", comteacher_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherAddress", txtteacher_address.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherImage", destinationPath);
                                    cmd.Parameters.AddWithValue("@teacherStatus", comteacher_status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateInsert", today.ToString("yyyy-MM-dd"));

                                    cmd.ExecuteNonQuery();

                                    teacherDisplayData();

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


        public void clearFields()
        {
            txtteacher_id.Text = "";
            txtteacher_name.Text = "";
            txtteacher_address.Text = "";
            comteacher_gender.SelectedIndex = -1;
            comteacher_status.SelectedIndex = -1;
            imgteacher.Image = null;
            imagepath = "";
        }


        private String imagepath;

        private void btnteacher_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg; *.png)|*.jpg;*.png";  

            if(open.ShowDialog() == DialogResult.OK)
            {
                imagepath = open.FileName;
                imgteacher.ImageLocation = imagepath;
            }
        }

        private void btnteacher_clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnteacher_update_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            if (txtteacher_id.Text == "" ||
               txtteacher_name.Text == "" ||
               txtteacher_address.Text == "" ||
               comteacher_gender.Text == "" ||
               comteacher_status.Text == "" ||
               imgteacher.Image == null
               )
            {
                MessageBox.Show("Please fill select blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    conn.Open();
                    DialogResult check = MessageBox.Show("Are you sure want to Update Teacher id: " + txtteacher_id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        string updateData = "INSERT teachers SET teacher_name = @teacherName, teacher_gender = @teacherGender, " +
                            "teacher_address = @teacherAddress,teacher_image = @teacherImage, teacher_status = @teacherStatus, date_insert, " +
                            "date_update = @dateUpdate WHERE teacher_id = @teacherID";
                    }
                }
                catch(Exception ex)
                {
                    
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void griddata_teacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = griddata_teacher.Rows[e.RowIndex];
                txtteacher_id.Text = row.Cells[1].Value.ToString();
                txtteacher_name.Text = row.Cells[2].Value.ToString();
                comteacher_gender.Text = row.Cells[3].Value.ToString();
                txtteacher_address.Text = row.Cells[4].Value.ToString();
                comteacher_status.Text = row.Cells[6].Value.ToString();

                // Load image correctly
                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "teacher_images", row.Cells[5].Value.ToString());

                if (File.Exists(imagePath)) // Ensure the file exists
                {
                    imgteacher.Image = Image.FromFile(imagePath);
                }
                else
                {
                    imgteacher.Image = null; // Clear image if not found
                //  MessageBox.Show("Image not found: " + imagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}

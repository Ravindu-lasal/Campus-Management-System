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
using MySql.Data.MySqlClient; 

namespace CampusManagementSystem
{
    public partial class Dashboardform : UserControl
    {
        public string connString = "Server=localhost;Database=campus;User ID=root;Password=12345;SslMode=none;";

        public Dashboardform()
        {
            InitializeComponent();
            displayTotaldata();
            displayTotalteacher();
            displayTotalGraduate();
            displaystudentGriddata();
        }


        public void displayTotaldata()
        {
            MySqlConnection conn = new MySqlConnection(connString);

            if(conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    string selectDate = "SELECT COUNT(id) FROM students WHERE student_status = 'Enrolled' AND date_delete IS NULL";

                    using(MySqlCommand cmd = new MySqlCommand(selectDate, conn))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        int temEs = 0;
                        if(reader.Read())
                        {
                            temEs = Convert.ToInt32(reader[0]);
                            lbltotalEs.Text = temEs.ToString();
                        }
                    }
                }

                catch(Exception ex) 
                {
                    MessageBox.Show("Error connection Database:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    conn.Close();
                }
            }
        }

        public void displayTotalteacher()
        {
            MySqlConnection conn = new MySqlConnection(connString);

            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    string selectDate = "SELECT COUNT(id) FROM teachers WHERE teacher_status = 'Active' AND date_delete IS NULL";

                    using (MySqlCommand cmd = new MySqlCommand(selectDate, conn))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        int temEs = 0;
                        if (reader.Read())
                        {
                            temEs = Convert.ToInt32(reader[0]);
                            lbltotalEt.Text = temEs.ToString();
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


        public void displayTotalGraduate()
        {
            MySqlConnection conn = new MySqlConnection(connString);

            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    string selectDate = "SELECT COUNT(id) FROM students WHERE student_status = 'Graduate' AND date_delete IS NULL";

                    using (MySqlCommand cmd = new MySqlCommand(selectDate, conn))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        int temEs = 0;
                        if (reader.Read())
                        {
                            temEs = Convert.ToInt32(reader[0]);
                            lbltotalGs.Text = temEs.ToString();
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

        public void displaystudentGriddata()
        {
            Addstudentsdata addgrid = new Addstudentsdata();

            StdataGridView.DataSource = addgrid.dashboardSTData();
        }

        private void Dashboardform_Load(object sender, EventArgs e)
        {

        }
    }
}

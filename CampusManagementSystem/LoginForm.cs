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

namespace CampusManagementSystem
{
    public partial class LoginForm : Form
    {

        public string connString = "Server=localhost;Database=campus;User ID=root;Password=12345;SslMode=none;";
        
        public LoginForm()
        
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtpwd.Text == "")
            {
                MessageBox.Show("Plaese fill all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        conn.Open();
                        string selectData = "SELECT * FROM users WHERE username = @username AND password = @password";

                        using (MySqlCommand cmd = new MySqlCommand(selectData, conn))
                        {
                            cmd.Parameters.AddWithValue("@username", txtname.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", txtpwd.Text.Trim());

                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                            {
                                DataTable table = new DataTable();
                                adapter.Fill(table);

                                if (table.Rows.Count > 0)
                                {
                                    MessageBox.Show("Login Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    MainForm mainForm = new MainForm();
                                    mainForm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Error: Incorrect username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



               
            }
        }

        private void showpwd_CheckedChanged(object sender, EventArgs e)
        { 
            txtpwd.PasswordChar = showpwd.Checked ? '\0' : '*';
        }

        private void txtpwd_TextChanged(object sender, EventArgs e)
        {
            txtpwd.PasswordChar = showpwd.Checked ? '\0' : '*';
        }
    }
}

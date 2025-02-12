using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusManagementSystem
{
    internal class Addstudentsdata
    {
        public string connString = "Server=localhost;Database=campus;User ID=root;Password=12345;SslMode=none;";


        public int id { get; set; }
        public string studentID { get; set; }

        public string studentName { get; set; }

        public string studentGender { get; set; }

        public string studentAddress { get; set; }

        public string studentGrade { get; set; }

        public string studentStatus { get; set; }

        public string studentSection { get; set; }

        public string studentImage { get; set; }

        public string insert_date { get; set; }

        public List<Addstudentsdata> studentData()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            List<Addstudentsdata> ListData = new List<Addstudentsdata>();

            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM students WHERE date_delete IS NULL";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Addstudentsdata addData = new Addstudentsdata();

                            addData.id = Convert.ToInt32(reader["id"]);
                            addData.studentID = reader["student_id"].ToString();
                            addData.studentName = reader["student_name"].ToString();
                            addData.studentGender = reader["student_gender"].ToString();
                            addData.studentAddress = reader["student_address"].ToString();
                            addData.studentGrade = reader["student_grade"].ToString();
                            addData.studentSection = reader["student_section"].ToString();
                            addData.studentImage = reader["student_image"].ToString();
                            addData.studentStatus = reader["student_status"].ToString();
                            addData.insert_date = reader["date_insert"].ToString();

                            ListData.Add(addData);
                        }
                    }

                }

                catch (Exception ex)
                {
                    Console.WriteLine("Error connecting Database" + ex.Message);
                }

                finally
                {
                    conn.Close();
                }
            }
            return ListData;
        }

        public List<Addstudentsdata> dashboardSTData()
        {
            List<Addstudentsdata> listdata = new List<Addstudentsdata>();

            MySqlConnection conn = new MySqlConnection(connString);

            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    DateTime today = DateTime.Today;

                    string sql = "SELECT * FROM students WHERE date_insert = @today AND date_delete IS NULL";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        // Use parameterized query to prevent SQL injection
                        cmd.Parameters.AddWithValue("@today", today.ToString("yyyy-MM-dd")); // Format date correctly

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Addstudentsdata addData = new Addstudentsdata();

                                addData.id = Convert.ToInt32(reader["id"]);
                                addData.studentID = reader["student_id"].ToString();
                                addData.studentName = reader["student_name"].ToString();
                                addData.studentGender = reader["student_gender"].ToString();
                                addData.studentAddress = reader["student_address"].ToString();
                                addData.studentGrade = reader["student_grade"].ToString();
                                addData.studentSection = reader["student_section"].ToString();
                                addData.studentImage = reader["student_image"].ToString();
                                addData.studentStatus = reader["student_status"].ToString();
                                addData.insert_date = Convert.ToDateTime(reader["date_insert"]).ToString("yyyy-MM-dd");

                                listdata.Add(addData);
                            }
                        }
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Error connecting Database" + ex.Message);
                }

                finally
                {
                    conn.Close();
                }
            }
            return listdata;
        }
    }
    
}

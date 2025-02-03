using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace CampusManagementSystem
{
    internal class Addteacherdata
    {
       
        private readonly string connString = "Server=localhost;Database=campus;User ID=root;Password=12345;SslMode=none;";

       
        public int id {  get; set; }
        public string teachertID { get; set; }

        public string teacherName { get; set; }

        public string teacherGender { get; set; }

        public string teacherAddress { get; set; }

        public string teacherimage { get; set;}

        public string teacherstatus { get; set; }

        public List<Addteacherdata> teacherData()
        {
            SqlConnection conn = new SqlConnection(connString);
            List<Addteacherdata> ListData = new List<Addteacherdata>();

            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM teachers WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Addteacherdata addData = new Addteacherdata();
                            addData.id = Convert.ToInt32(reader["ID"]);
                            addData.teachertID = reader["teacher_id"].ToString();
                            addData.teacherName = reader["teacher_name"].ToString();
                            addData.teacherGender = reader["teacher_gender"].ToString();
                            addData.teacherAddress = reader["teacher_address"].ToString();
                            addData.teacherstatus = reader["teacher_status"].ToString();

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
        
    }
}

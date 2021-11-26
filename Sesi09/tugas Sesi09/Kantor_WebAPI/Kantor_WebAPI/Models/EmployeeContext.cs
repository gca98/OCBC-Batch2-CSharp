using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Kantor_WebAPI.Models
{
    public class EmployeeContext
    {
        public string ConnectionString { get; set; }

        public EmployeeContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<EmployeeItem> GetAllEmployee()
        {
            List<EmployeeItem> list = new List<EmployeeItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jeniskelamin = reader.GetString("jenis_kelamin"),
                            alamat = reader.GetString("alamat")

                        });
                    }
                }
            }
            return list;
        }
        public List<EmployeeItem> GetEmployee(string id)
        {
            List<EmployeeItem> list = new List<EmployeeItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee where id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jeniskelamin = reader.GetString("jenis_kelamin"),
                            alamat = reader.GetString("alamat")

                        });
                    }
                }
            }
            return list;
        }

        public string InsertEmployee(EmployeeItem dataemployee)
        {


            List<EmployeeItem> list = new List<EmployeeItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                try
                {

                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO employee(nama,jenis_kelamin,alamat) VALUES(@nama,@jenis_kelamin,@alamat)", conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", dataemployee.nama);
                        cmd.Parameters.AddWithValue("@jenis_kelamin", dataemployee.jeniskelamin);
                        cmd.Parameters.AddWithValue("@alamat", dataemployee.alamat);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    return "MASUK";
                }
                catch (Exception err)
                {
                    return "";
                }



            }

        }
        public void UpdateEmployee(int id, EmployeeItem dataemployee)
        {
            List<EmployeeItem> list = new List<EmployeeItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand("UPDATE employee SET nama = @nama, jenis_kelamin = @jenis_kelamin, alamat = @alamat where id = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", dataemployee.nama);
                        cmd.Parameters.AddWithValue("@jenis_kelamin", dataemployee.jeniskelamin);
                        cmd.Parameters.AddWithValue("@alamat", dataemployee.alamat);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    
                }
                catch (Exception err)
                {
                    
                }
            }
        }

        public void DeleteEmployee(int id)
        {
            List<EmployeeItem> list = new List<EmployeeItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand("DELETE from employee where id = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    
                }
                catch (Exception err)
                {
                    
                }
            }
        }

    }
}

using System;
using System.Data;
using System.Data.SqlClient;

namespace Database_Example
{
    class CrudOperation
    {
        // Centralized method to retrieve connection string
        private string GetConnectionString()
        {
            return "Data Source=KUNWAR-NISCHAL\\SQLEXPRESS;Initial Catalog=db_nccsb;Integrated Security=true";
        }

        public void CreateTable()
        {
            string tblQuery = @"CREATE TABLE tbl_reg (
                                id INT PRIMARY KEY,
                                username VARCHAR(50) NOT NULL,
                                password VARCHAR(256) NOT NULL,
                                gender VARCHAR(50),
                                faculty VARCHAR(50))";
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(tblQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Table created successfully.");
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error creating table: {ex.Message}");
            }
        }

        public void InsertData()
        {
            try
            {
                Console.WriteLine("Enter your id: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your username: ");
                string username = Console.ReadLine();

                Console.WriteLine("Enter your password: ");
                string password = Console.ReadLine(); // Hash this in production

                Console.WriteLine("Enter your gender: ");
                string gender = Console.ReadLine();

                Console.WriteLine("Enter your faculty: ");
                string faculty = Console.ReadLine();

                string insQuery = @"INSERT INTO tbl_reg (id, username, password, gender, faculty)
                                    VALUES (@id, @username, @password, @gender, @faculty)";

                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(insQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password); // Hash passwords in production
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@faculty", faculty);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} record(s) inserted.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inserting data: {ex.Message}");
            }
        }

        public void UpdateData()
        {
            try
            {
                Console.WriteLine("Enter the ID of the record to update: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter new username: ");
                string username = Console.ReadLine();

                Console.WriteLine("Enter new faculty: ");
                string faculty = Console.ReadLine();

                string upQuery = @"UPDATE tbl_reg SET username = @username, faculty = @faculty WHERE id = @id";

                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(upQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@faculty", faculty);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} record(s) updated.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating data: {ex.Message}");
            }
        }

        public void DisplayData()
        {
            try
            {
                string disQuery = "SELECT * FROM tbl_reg WHERE gender = 'male' AND faculty = 'bim'";

                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(disQuery, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            Console.WriteLine("------------- Data from Database --------------------");
                            while (reader.Read())
                            {
                                Console.WriteLine($"ID: {reader["id"]}");
                                Console.WriteLine($"Username: {reader["username"]}");
                                Console.WriteLine($"Gender: {reader["gender"]}");
                                Console.WriteLine($"Faculty: {reader["faculty"]}");
                                Console.WriteLine("------------------------------------------------");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error displaying data: {ex.Message}");
            }
        }

        public void DeleteData()
        {
            try
            {
                Console.WriteLine("Enter the ID of the record to delete: ");
                int id = int.Parse(Console.ReadLine());

                string delQuery = "DELETE FROM tbl_reg WHERE id = @id";

                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(delQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} record(s) deleted.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting data: {ex.Message}");
            }
        }
    }
}

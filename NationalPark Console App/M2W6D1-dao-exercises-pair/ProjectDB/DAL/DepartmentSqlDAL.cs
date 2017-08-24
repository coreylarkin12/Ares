using ProjectDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectDB.DAL
{
    public class DepartmentSqlDAL
    {
        private string connectionString;
        private const string SQL_GetDepartments = "SELECT * FROM department";
        private const string SQL_CreateDepartment = @"INSERT INTO department VALUES (@departmentName);";
        private const string SQL_UpdateDepartment = @"UPDATE department SET name = @updatedName WHERE department_id = @department_id;";

        // Single Parameter Constructor
        public DepartmentSqlDAL(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<Department> GetDepartments()
        {
            List<Department> output = new List<Department>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = SQL_GetDepartments;
                    cmd.Connection = connection;

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Department d = new Department();
                        d.Id = Convert.ToInt32(reader["department_id"]);
                        d.Name = Convert.ToString(reader["name"]);
                        output.Add(d);
                    }  
                }
            }
            catch (SqlException ex)
            {
                // Log 
                throw;
            }
            return output;
        }

        public bool CreateDepartment(Department newDepartment)
        {
            try
            {
                using (SqlConnection CreateConn = new SqlConnection(connectionString))
                {
                    CreateConn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_CreateDepartment, CreateConn);
                    cmd.Parameters.AddWithValue("@departmentName", newDepartment.Name);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return (rowsAffected > 0);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("DID NOT CREATE");
                throw;
            }
        }

        public bool UpdateDepartment(Department updatedDepartment)
        {
            try
            {
                using (SqlConnection updateConn = new SqlConnection(connectionString))
                {
                    updateConn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_UpdateDepartment, updateConn);
                    cmd.Parameters.AddWithValue("@department_id", updatedDepartment.Id);
                    cmd.Parameters.AddWithValue("@updatedName", updatedDepartment.Name);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return (rowsAffected > 0);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("DID NOT UPDATE");
                throw;
            }
        }

    }
}

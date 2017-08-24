using ProjectDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectDB.DAL
{
    public class EmployeeSqlDAL
    {
        private string connectionString;
        private const string SQL_GetEmployees = "SELECT * FROM employee";
        private const string SQL_SearchEmployees = @"SELECT * FROM employee WHERE first_name = @firstname OR last_name = @lastname;";
        private const string SQL_WithoutProject = "SELECT * FROM employee e LEFT JOIN project_employee pe ON pe.employee_id = e.employee_id WHERE pe.employee_id IS NULL;";

        // Single Parameter Constructor
        public EmployeeSqlDAL(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> output = new List<Employee>();

            try
            {
                using(SqlConnection connections = new SqlConnection(connectionString))
                {
                    connections.Open();

                    
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = SQL_GetEmployees;
                    cmd.Connection = connections;

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Employee e = new Employee();
                        e.EmployeeId = Convert.ToInt32(reader["employee_id"]);
                        e.DepartmentId = Convert.ToInt32(reader["department_id"]);
                        e.FirstName = Convert.ToString(reader["first_name"]);
                        e.LastName = Convert.ToString(reader["last_name"]);
                        e.JobTitle = Convert.ToString(reader["job_title"]);
                        e.BirthDate = Convert.ToDateTime(reader["birth_date"]);
                        e.Gender = Convert.ToString(reader["gender"]);
                        e.HireDate = Convert.ToDateTime(reader["hire_date"]);
                        output.Add(e);
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

        public List<Employee> Search(string firstname, string lastname)
        {
            List<Employee> output = new List<Employee>();

            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_SearchEmployees, conn);
                    cmd.Parameters.AddWithValue("@firstname", firstname);
                    cmd.Parameters.AddWithValue("@lastname", lastname);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Employee n = new Employee();
                        n.FirstName = Convert.ToString(reader["first_name"]);
                        n.LastName = Convert.ToString(reader["last_name"]);
                        n.DepartmentId = Convert.ToInt32(reader["department_id"]);
                        n.JobTitle = Convert.ToString(reader["job_title"]);
                        n.Gender = Convert.ToString(reader["gender"]);
                        n.HireDate = Convert.ToDateTime(reader["hire_date"]);
                        n.BirthDate = Convert.ToDateTime(reader["birth_date"]);
                        output.Add(n);
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

        public List<Employee> GetEmployeesWithoutProjects()
        {
            List<Employee> output = new List<Employee>();

            try
            {
                using(SqlConnection withoutConn = new SqlConnection(connectionString))
                {
                    withoutConn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_WithoutProject, withoutConn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Employee w = new Employee();
                        w.EmployeeId = Convert.ToInt32(reader["employee_id"]);
                        w.FirstName = Convert.ToString(reader["first_name"]);
                        w.LastName = Convert.ToString(reader["last_name"]);
                        w.DepartmentId = Convert.ToInt32(reader["department_id"]);
                        w.JobTitle = Convert.ToString(reader["job_title"]);
                        w.Gender = Convert.ToString(reader["gender"]);
                        w.HireDate = Convert.ToDateTime(reader["hire_date"]);
                        w.BirthDate = Convert.ToDateTime(reader["birth_date"]);
                        output.Add(w);
                    }
                }
            }
            catch(SqlException ex)
            {
                throw;
            }
            return output;
        }
    }
}

using ProjectDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectDB.DAL
{
    public class ProjectSqlDAL
    {
        private string connectionString;
        private const string SQL_GetProjects = "SELECT * FROM project";
        private const string SQL_AssignProject = @"INSERT INTO project_employee values (@project_id, @employee_id);";
        private const string SQL_RemoveProject = @"DELETE FROM project_employee WHERE project_id = @project_id AND employee_id = @employee_id;";
        private const string SQL_CreateProject = @"INSERT INTO project VALUES (@projectName, @startDate, @endDate);";

        // Single Parameter Constructor
        public ProjectSqlDAL(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<Project> GetAllProjects()
        {
            List<Project> output = new List<Project>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = SQL_GetProjects;
                    cmd.Connection = connection;

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Project p = new Project();
                        p.ProjectId = Convert.ToInt32(reader["project_id"]);
                        p.Name = Convert.ToString(reader["name"]);
                        p.StartDate = Convert.ToDateTime(reader["from_date"]);
                        p.EndDate = Convert.ToDateTime(reader["to_date"]);

                        output.Add(p);
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

        public bool AssignEmployeeToProject(int projectId, int employeeId)
        {
           
            try
            {
                using(SqlConnection assignConn = new SqlConnection(connectionString))
                {
                    assignConn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_AssignProject, assignConn);
                    cmd.Parameters.AddWithValue("@project_id", projectId);
                    cmd.Parameters.AddWithValue("@employee_id", employeeId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return (rowsAffected > 0);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("DID NOT CREATE " + ex.InnerException.ToString());
                throw;
            }
        }

        public bool RemoveEmployeeFromProject(int projectId, int employeeId)
        {
            try
            {
                using (SqlConnection removeConn = new SqlConnection(connectionString))
                {
                    removeConn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_RemoveProject, removeConn);
                    cmd.Parameters.AddWithValue("@project_id", projectId);
                    cmd.Parameters.AddWithValue("@employee_id", employeeId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return (rowsAffected > 0);
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        public bool CreateProject(Project newProject)
        {
            try
            {
                using(SqlConnection createConn = new SqlConnection(connectionString))
                {
                    createConn.Open();
                    SqlCommand cmd = new SqlCommand(SQL_CreateProject, createConn);
                    cmd.Parameters.AddWithValue("@projectName", newProject.Name);
                    cmd.Parameters.AddWithValue("@startDate", newProject.StartDate);
                    cmd.Parameters.AddWithValue("@endDate", newProject.EndDate);

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

    }
}

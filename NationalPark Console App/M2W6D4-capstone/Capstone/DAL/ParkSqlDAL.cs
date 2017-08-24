using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Models;
using System.Data.SqlClient;

namespace Capstone.DAL
{
    public class ParkSqlDAL
    {
        private string connectionString;
        private const string SQL_GetAllParks = "SELECT * FROM park";

        public ParkSqlDAL(string dataConnection)
        {
            connectionString = dataConnection;
        }

        public List<Park> GetParks()
        {
            List<Park> output = new List<Park>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GetAllParks, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Park p = new Park();
                        p.Id = Convert.ToInt32(reader["park_id"]);
                        p.ParkName = Convert.ToString(reader["name"]);
                        p.Location = Convert.ToString(reader["location"]);
                        p.EstablishDate = Convert.ToDateTime(reader["establish_date"]);
                        p.Area = Convert.ToInt32(reader["area"]);
                        p.Visitors = Convert.ToInt32(reader["visitors"]);
                        p.Description = Convert.ToString(reader["description"]);
                        output.Add(p);
                    }

                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("There was an Error");
                throw;
            }
            return output;
        }

    }
}

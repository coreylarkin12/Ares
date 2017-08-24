using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Models;
using System.Data.SqlClient;

namespace Capstone.DAL
{
    public class CampgroundSqlDAL
    {
        private string connectionString;
        private const string SQL_GetAllCampgrounds = "SELECT * FROM campground WHERE park_id = @parkId;";

        public CampgroundSqlDAL (string dataConnection)
        {
            connectionString = dataConnection;
        }

        public List<Campground> GetCampgrounds(int parkId)
        {
            List<Campground> output = new List<Campground>();

            try
            {
                using(SqlConnection connections = new SqlConnection(connectionString))
                {
                    connections.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GetAllCampgrounds, connections);
                    cmd.Parameters.AddWithValue("@parkId", parkId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Campground c = new Campground();
                        c.CampgroundId = Convert.ToInt32(reader["campground_id"]);
                        c.ParkId = Convert.ToInt32(reader["park_id"]);
                        c.Name = Convert.ToString(reader["name"]);
                        string openMonth = Convert.ToString(reader["open_from_mm"]);
                        string closeMonth = Convert.ToString(reader["open_to_mm"]);
                        c.OpenMonth =GetMonths(openMonth);
                        c.CloseMonth = GetMonths(closeMonth);
                        c.DailyFee = Convert.ToDouble(reader["daily_fee"]);
                        output.Add(c);
                    }
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine("There was an error");
                throw;
            }
            return output;
        }

        public string GetMonths(string input)
        {
            string month = "";

            switch (input)
            {
                case "1":
                    month = "January";
                    break;
                case "2":
                    month = "February";
                    break;
                case "3":
                    month = "March";
                    break;
                case "4":
                    month = "April";
                    break;
                case "5":
                    month = "May";
                    break;
                case "6":
                    month = "June";
                    break;
                case "7":
                    month = "July";
                    break;
                case "8":
                    month = "August";
                    break;
                case "9":
                    month = "September";
                    break;
                case "10":
                    month = "October";
                    break;
                case "11":
                    month = "November";
                    break;
                case "12":
                    month = "December";
                    break;
                default:
                    Console.WriteLine("There was error");
                    break;
                
            }
            return month;
        }


    }
}

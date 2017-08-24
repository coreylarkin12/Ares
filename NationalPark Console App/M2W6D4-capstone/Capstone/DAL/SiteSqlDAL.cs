using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Models;
using System.Data.SqlClient;

namespace Capstone.DAL
{
    public class SiteSqlDAL
    {                                                 
        private string connectionString;
        private const string SQL_GetCampsites = "SELECT TOP 5 site.site_id, site.site_number, site.max_occupancy, site.accessible, site.max_rv_length, site.utilities, campground.daily_fee FROM site JOIN campground on campground.campground_id = site.campground_id JOIN reservation on reservation.site_id = site.site_id WHERE (@startDate <= reservation.from_date OR reservation.to_date <= @endDate) AND site.campground_id = @campgroundId GROUP BY site.site_id, site.site_number, site.max_occupancy, site.accessible, site.max_rv_length, site.utilities, campground.daily_fee;";
       

        public SiteSqlDAL (string dataConnection)
        {
            connectionString = dataConnection;
        }

        /// <summary>
        /// Our GetSites method which is called in our capstone cli and has 3 parameters and uses a list and converts everythings then
        /// adds the new values to the list and returns that list 
        /// </summary>
        /// <param name="campgroundId"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public List<Site> GetSites(int campgroundId, DateTime startDate, DateTime endDate)
        {
            List<Site> output = new List<Site>();

            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GetCampsites, conn);
                    cmd.Parameters.AddWithValue("@campgroundId", campgroundId);
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        
                        Site s = new Site();
                        s.SiteId = Convert.ToInt32(reader["site_id"]);
                        s.SiteNumber = Convert.ToInt32(reader["site_number"]);
                        s.MaxOccupancy = Convert.ToInt32(reader["max_occupancy"]);
                        string isAccessible = Convert.ToString(reader["accessible"]);
                        string isUtility = Convert.ToString(reader["utilities"]);
                        s.Accessible = GetValues(isAccessible);
                        s.Utility = GetValues(isUtility);
                        s.MaxRvLength = Convert.ToInt32(reader["max_rv_length"]);
                        s.Cost = Convert.ToDouble (reader["daily_fee"]);
                        s.totalCost = s.Cost * (endDate - startDate).TotalDays;
                  
                        output.Add(s);

                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("There was an error");
                throw;
            }
            return output;
        }
        /// <summary>
        /// we use this method to be able to convert the accessible and utilities columns of the database from 0, 1 to yes and no 
        /// we cal this method in the above mthod during our conversions. Could have used an if statement here
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string GetValues(string input)
        {
            string value = "";
            switch (input)
            {
                case "True":
                    value = "Yes";
                    break;
                case "False":
                    value = "No";
                    break;
                default:
                    value = "broken";
                    break;
                
            }
            return value;
        }
    }
}

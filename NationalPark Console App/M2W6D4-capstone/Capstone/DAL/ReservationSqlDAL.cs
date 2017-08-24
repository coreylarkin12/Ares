using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Models;
using System.Data.SqlClient;

namespace Capstone.DAL
{
    public class ReservationSqlDAL
    {

        private string connectionString;
        private const string SQL_MakeReservation = "INSERT INTO reservation VALUES (@site_id, @name, @startDate, @endDate, @createDate);" + "SELECT SCOPE_IDENTITY();";

        public ReservationSqlDAL(string dataConnection)
        {
            connectionString = dataConnection;
        }

        public List<Reservation> MakeReservation(Reservation newReservation)
        {
            List<Reservation> output = new List<Reservation>();

            try
            {
                using (SqlConnection resConnection = new SqlConnection(connectionString))
                {
                    resConnection.Open();

                    SqlCommand cmd = new SqlCommand(SQL_MakeReservation, resConnection);
                    cmd.Parameters.AddWithValue("@site_id", newReservation.SiteID);
                    cmd.Parameters.AddWithValue("@name", newReservation.Name);
                    cmd.Parameters.AddWithValue("@startDate", newReservation.FromDate);
                    cmd.Parameters.AddWithValue("@endDate", newReservation.ToDate);
                    cmd.Parameters.AddWithValue("@createDate", newReservation.CreateDate);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        cmd = new SqlCommand("SELECT * FROM reservation WHERE name = @name AND site_id = @site_id AND from_date = @startDate AND to_date = @endDate AND create_date = @createDate;", resConnection);
                        cmd.Parameters.AddWithValue("@site_id", newReservation.SiteID);
                        cmd.Parameters.AddWithValue("@name", newReservation.Name);
                        cmd.Parameters.AddWithValue("@startDate", newReservation.FromDate);
                        cmd.Parameters.AddWithValue("@endDate", newReservation.ToDate);
                        cmd.Parameters.AddWithValue("@createDate", newReservation.CreateDate);

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Reservation r = new Reservation();
                            r.ReservationId = Convert.ToInt32(reader["reservation_id"]);
                            r.SiteID = Convert.ToInt32(reader["site_id"]);
                            r.Name = Convert.ToString(reader["name"]);
                            r.FromDate = Convert.ToDateTime(reader["from_date"]);
                            r.ToDate = Convert.ToDateTime(reader["to_date"]);
                            r.CreateDate = Convert.ToDateTime(reader["create_date"]);

                            output.Add(r);

                        }

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
    }
}

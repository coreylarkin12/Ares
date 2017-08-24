using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormsWithHttpPost.Models;
using System.Data.SqlClient;

namespace FormsWithHttpPost.DAL
{
    public class ReviewSqlDAL : IReviewDAL
    {
        private string connectionString;


        public ReviewSqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Review> GetAllReviews()
        {
            List<Review> output = new List<Review>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM reviews", connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Review r = new Review();
                        r.Id = Convert.ToInt32(reader["review_id"]);
                        r.Username = Convert.ToString(reader["username"]);
                        r.Rating = Convert.ToInt32(reader["rating"]);
                        r.Title = Convert.ToString(reader["review_title"]);
                        r.Message = Convert.ToString(reader["review_text"]);
                        r.ReviewDate = Convert.ToDateTime(reader["review_date"]);
                        output.Add(r);
                    }
                }
            }
            catch (SqlException e)
            {
                throw;
            }
            return output;
        }

        public bool SaveReview(Review newReview)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO reviews VALUES(@userName, @rating, @title, @text, @review_Date)", conn);

                    cmd.Parameters.AddWithValue("@userName", newReview.Username);
                    cmd.Parameters.AddWithValue("@rating", newReview.Rating);
                    cmd.Parameters.AddWithValue("@title", newReview.Title);
                    cmd.Parameters.AddWithValue("@text", newReview.Message);
                    cmd.Parameters.AddWithValue("@review_Date", DateTime.UtcNow);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return (rowsAffected > 0);
                }
            }
            catch (SqlException ex)
            {
                // Error Logging that a problem occurred, don't show the user
                throw;
            }
        }
    }
}
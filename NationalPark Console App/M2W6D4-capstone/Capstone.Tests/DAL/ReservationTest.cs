using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using System.Data.SqlClient;
using Capstone.DAL;
using System.Collections.Generic;
using Capstone.Models;
using System;

namespace Capstone.Tests
{
    [TestClass()]
    public class ReservationTest
    {
        private TransactionScope tran;
        private string connectionString = @"Data Source = localhost\sqlexpress;Initial Catalog = NationalPark; Integrated Security = True";

        [TestInitialize]
        public void Initialize()
        {
            tran = new TransactionScope();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd;
                connection.Open();

                cmd = new SqlCommand("INSERT INTO reservation VALUES (1, 'corey', '2017-01-01', '2017-01-10', '2017-06-16');", connection);
                cmd.ExecuteNonQuery();
            }
        }

        [TestCleanup()]
        public void Cleanup()
        {
            tran.Dispose();
        }

        [TestMethod()]
        public void MakeReservationTest()
        {
            ReservationSqlDAL testRes = new ReservationSqlDAL(connectionString);

        }
    }
}

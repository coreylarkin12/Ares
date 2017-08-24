using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using System.Data.SqlClient;
using Capstone.DAL;
using System.Collections.Generic;
using Capstone.Models;

namespace Capstone.Tests
{
    [TestClass()]
    public class ParkTests
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

                cmd = new SqlCommand("INSERT INTO park VALUES ('test park', 'ohio', '1990-02-02', 35333, 250832, 'A beautiful park');", connection);
                cmd.ExecuteNonQuery();
            }
        }

        [TestCleanup()]
        public void Cleanup()
        {
            tran.Dispose();
        }

        [TestMethod()]
        public void GetAllParksTest()
        {
            ParkSqlDAL testPark = new ParkSqlDAL(connectionString);
            List<Park> testList = testPark.GetParks();

            Assert.AreEqual(4, testList.Count);
            Assert.AreEqual("test park", testList[3].ParkName);
            Assert.AreEqual("ohio", testList[3].Location);
        }

    }
}
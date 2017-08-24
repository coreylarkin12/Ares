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
    public class CampgroundTests
    {
        private TransactionScope tran;
        private string connectionString = @"Data Source = localhost\sqlexpress;Initial Catalog = NationalPark; Integrated Security = True";

        [TestInitialize]
        public void Initialize()
        {
            tran = new TransactionScope();

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd;
                connection.Open();

                cmd = new SqlCommand("INSERT INTO campground VALUES (1,'test campground', 1, 12, 35);", connection);
                cmd.ExecuteNonQuery();
            }
        }

        [TestCleanup()]
        public void Cleanup()
        {
            tran.Dispose();
        }
        [TestMethod()]
        public void GetAllCampgroundsTest()
        {
            CampgroundSqlDAL dal = new CampgroundSqlDAL(connectionString);
            List<Campground> testList = dal.GetCampgrounds(1);

            Assert.AreEqual(1, testList[0].ParkId);
            Assert.AreEqual(4, testList.Count);
            Assert.IsNotNull(testList);
        }
        [TestMethod()]
        public void GetMonthsTest()
        {
            CampgroundSqlDAL testMonth = new CampgroundSqlDAL(connectionString);

            Assert.AreEqual("January", testMonth.GetMonths("1"));
            Assert.AreEqual("March", testMonth.GetMonths("3"));
            Assert.AreEqual("September", testMonth.GetMonths("9"));
        }
    }
}

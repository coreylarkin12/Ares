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
    public class SiteTests
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

                cmd = new SqlCommand("INSERT INTO site (campground_id, site_number, max_occupancy, accessible, utilities, max_rv_length) VALUES ( 1, 1 ,6, 1, 1, 35);", connection);
                cmd.ExecuteNonQuery();
            }
        }

        [TestCleanup()]
        public void Cleanup()
        {
            tran.Dispose();
        }

        [TestMethod()]
        public void GetAllSitesTest()
        {
            SiteSqlDAL testSite = new SiteSqlDAL(connectionString);
            List<Site> siteList = testSite.GetSites(1, System.DateTime.Now, System.DateTime.Today);

            Assert.AreEqual(2, siteList[1].SiteId);
            Assert.AreEqual(0, siteList[3].MaxRvLength);
            Assert.AreEqual("No", siteList[0].Accessible);

        }

        [TestMethod()]
        public void GetValuesTest()
        {
            SiteSqlDAL testDal = new SiteSqlDAL(connectionString);

            Assert.AreEqual("Yes", testDal.GetValues("True"));
            Assert.AreEqual("No", testDal.GetValues("False"));
            Assert.AreEqual("broken", testDal.GetValues("Null"));
        }
    }
}

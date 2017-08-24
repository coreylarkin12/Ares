using System;
using ProjectDB.DAL;
using ProjectDB.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ProjectDBTest.DAL
{
    [TestClass]
    public class ProjectTests
    {
        private TransactionScope tran;
        private string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=Projects;Integrated Security=True";

        [TestInitialize]
        public void Initialize()
        {
            tran = new TransactionScope();

            using (SqlConnection testconn = new SqlConnection(connectionString))
            {
                SqlCommand cmd;
                testconn.Open();

                cmd = new SqlCommand("INSERT INTO project VALUES ('myTEST', '1992-03-27', '2010-01-01');", testconn);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("INSERT INTO project_employee values(6 ,4 );", testconn);
                cmd.ExecuteNonQuery();

            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }

        [TestMethod()]
        public void GetAllProjectsTest()
        {
            ProjectSqlDAL projectTest = new ProjectSqlDAL(connectionString);
            List<Project> testList = projectTest.GetAllProjects();

            Assert.AreEqual(7, testList.Count);
            Assert.AreEqual("myTEST", testList[6].Name);
        }

        [TestMethod()]
        public void AssignEmployeeTest()
        {
            ProjectSqlDAL projectTest = new ProjectSqlDAL(connectionString);
            bool isAssigned = projectTest.AssignEmployeeToProject(6, 1);

            Assert.IsTrue(isAssigned);
        }

        [TestMethod()]
        public void RemoveEmployeeTest()
        {
            ProjectSqlDAL projectTest = new ProjectSqlDAL(connectionString);
            bool isRemoved = projectTest.RemoveEmployeeFromProject(6, 4);

            Assert.IsTrue(isRemoved);
        }

        [TestMethod()]
        public void CreateProjectTest()
        {
            ProjectSqlDAL projectTest = new ProjectSqlDAL(connectionString);
            DateTime dt = DateTime.Now;
            Project secondTest = new Project
            {
                Name = "secondTest",
                StartDate = dt,
                EndDate = dt

            };

            bool isCreated = projectTest.CreateProject(secondTest);

            Assert.IsTrue(isCreated);
        }
    }
}

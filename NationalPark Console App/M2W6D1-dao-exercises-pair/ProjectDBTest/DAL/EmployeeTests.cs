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
    public class EmployeeTests
    {
        private TransactionScope tran;
        private string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=Projects;Integrated Security=True";
        private int numOfEmployee = 0;

        [TestInitialize]
        public void Initialize()
        {
            tran = new TransactionScope();
            List<Employee> output = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd;
                conn.Open();

                cmd = new SqlCommand("SELECT COUNT(*) FROM employee;", conn);
                numOfEmployee = (int)cmd.ExecuteScalar();
                
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }

        [TestMethod()]
        public void GetAllEmployeesTest()
        {
            EmployeeSqlDAL testEmployee = new EmployeeSqlDAL(connectionString);
            List<Employee> testList = testEmployee.GetAllEmployees();

            Assert.AreEqual(numOfEmployee, testList.Count);
        }

        [TestMethod()]
        public void SearchEmployeesTest()
        {
            EmployeeSqlDAL testEmployee = new EmployeeSqlDAL(connectionString);
            List<Employee> testList = testEmployee.Search("Sid", "Goodman");

            Assert.AreEqual("Sid", testList[0].FirstName);
            Assert.AreEqual("Goodman", testList[0].LastName);
            Assert.AreEqual(1, testList.Count);
        }

        [TestMethod()]
        public void GetWithoutProjectsTest()
        {
            EmployeeSqlDAL testEmployee = new EmployeeSqlDAL(connectionString);
            List<Employee> withoutList = testEmployee.GetEmployeesWithoutProjects();

            Assert.AreEqual(2, withoutList.Count);
            Assert.AreEqual("Coty", withoutList[0].LastName);

        }
    }
}

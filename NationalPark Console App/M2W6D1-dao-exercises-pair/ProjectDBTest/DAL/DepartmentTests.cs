using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectDB.Models;
using ProjectDB.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Data.SqlClient;

namespace ProjectDBTest
{
    [TestClass()]
    public class DepartmentTests
    {
        private TransactionScope tran;
        private string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=Projects;Integrated Security=True";


        [TestInitialize]
        public void Initialize()
        {
            tran = new TransactionScope();

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd;
                connection.Open();

                cmd = new SqlCommand("INSERT INTO department VALUES ('test department');", connection);
                cmd.ExecuteNonQuery();
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }

        [TestMethod()]
        public void GetAllDepartmentsTest()
        {
            DepartmentSqlDAL testDept = new DepartmentSqlDAL(connectionString);
            List<Department> testList = testDept.GetDepartments();

            Assert.AreEqual(7, testList.Count);
        }

        [TestMethod()]
        public void CreateDepartmentTest()
        {
            DepartmentSqlDAL testDept = new DepartmentSqlDAL(connectionString);
            Department newDept = new Department
            {
                Name = "MyTestDept"
            };
            bool isCreated = testDept.CreateDepartment(newDept);

            Assert.IsTrue(isCreated);
        }

        [TestMethod()]
        public void UpdateDepartmentTest()
        {
            DepartmentSqlDAL testDept = new DepartmentSqlDAL(connectionString);
            Department myDept = new Department
            {
                Id = 5,
                Name = "NewTestDept"
            };

            bool isUpdated = testDept.UpdateDepartment(myDept);

            Assert.IsTrue(isUpdated);
        }
    }


}

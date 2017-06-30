using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace DataDrivenTest
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        private static TestContext _testContext;
        [ClassInitialize]
        public static void startup(TestContext testContext)
        {
            _testContext = testContext;
        }

        [TestMethod]
        //[DataSource("System.Data.SqlClient",
        //            "data source=ICAN-52\\SQLEXPRESS14;database=BeeboxDemo82Sitecore_Web;integrated security=true",
        //            "zEmployees", DataAccessMethod.Sequential)]

        [DataSource("UnitTestDataSource")]
       // [DataSource(@"Provider=Microsoft.SqlServerCe.Client.4.0;Data Source=C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS14\MSSQL\DATA\Employees.sdf", "AddIntegersData")]
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Employees.xml", "Employee", DataAccessMethod.Sequential)]
        // [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"|DataDirectory|\Employees.csv", "Employees#csv", DataAccessMethod.Sequential)]
        // [DataSource("data source=ICAN-52\\SQLEXPRESS14;database=BeeboxDemo82Sitecore_Web;integrated security=true","zEmployees")]
        //[DataSource("Provider=System.Data.SqlClient", "Data Source=ICAN-52\\SQLEXPRESS14;database=BeeboxDemo82Sitecore_Web;integrated security=true;", "zEmployees",DataAccessMethod.Sequential)]           
        public void DataDriveEmployeeTest()
        {
            Employee emp = new Employee();
            emp.Name = TestContext.DataRow["Name"].ToString();
            emp.Email = TestContext.DataRow["Email"].ToString();

            Assert.IsNotNull(emp.Email);
            Assert.IsNotNull(emp.Name);


        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace TestProject
{
    [TestClass]
    public class DivideTest
    {
        //    private static TestContext _testContext;
        //    public TestContext testContext
        //    {
        //        get  { return _testContext; }
        //        set { _testContext = value; }
        //    }


        public TestContext TestContext { get; set; }

        private static TestContext _testContext;

        [ClassInitialize]
        public static void SetupTests(TestContext testContext)
        {
            _testContext = testContext;
        }

        [TestMethod]
        [Priority(1)]
        [TestProperty("Ashraf","performance")]
        [TestCategory("security")]
        public void Test_Divide()
        {
            //Arrange
            int num1 = 100;
            int num2 = 20;
            int expectedValue = 5;
            //Avoke

            int actualValue = Program.Divide(num1, num2);
            //Assert

            Assert.AreEqual(expectedValue, actualValue);
            TestContext.WriteLine("testContext");
        }
        [TestMethod]
        public void IsPositive_PositiveNumber_Bool()
        {
            PrivateObject p = new PrivateObject(typeof(Program));
            bool actual =  (bool) p.Invoke("IsPositive",10);
            Assert.IsTrue(actual);
        }
    }
}

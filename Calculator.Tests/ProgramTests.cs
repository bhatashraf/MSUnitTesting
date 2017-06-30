using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    
    [TestClass()]
    public class ProgramTests
    {
        public TestContext TestContext { get; set; }

        private static TestContext _testContext;
        [ClassInitialize]
        public  static void startup(TestContext testContext )
        {
            _testContext = testContext;
        }

        [Priority(2)]
        [TestMethod()]
        public void DivideTest()
        {
            Assert.IsFalse(false);
        }
        [TestMethod()]
        [Priority(1)]
        public void DivideTest2()
        {

            System.Threading.Thread.Sleep(1000);
            Assert.AreEqual(5,10/2);
            System.Diagnostics.Debug.WriteLine("writing things to output window");
            TestContext.WriteLine(TestContext.TestName);
          //  _testContext.WriteLine(_testContext.TestName);

        }
    }
}
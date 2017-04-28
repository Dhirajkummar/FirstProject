using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinTest.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void AddTwoPostiveNumberTest()
        {
            Class1 test = new Class1();
            var result = test.AddTwoPostiveNumber(10, 20);
            Assert.IsTrue(result == 30);
            //Assert.Fail();
        }
    }
}
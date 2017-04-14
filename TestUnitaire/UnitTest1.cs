using System;
using JenkinsTP;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitaire
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            int result = Program.Add(5, 2);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void TestDiv()
        {
            int result = Program.Div(12, 2);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException),
    "Div by 0")]
        public void TestDivFail()
        {
            int result = Program.Div(12, 0);
            Assert.Fail();
        }
    }
}

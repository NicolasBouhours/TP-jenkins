using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using JenkinsTP;

namespace UnitTestNUnit
{
    class NUnitTest
    {

        static void Main(string[] args)
        {

        }

        [Test]
        public void TestAdd()
        {
            int result = Program.Add(5, 2);
            Assert.AreEqual(7, result);
        }

        [Test]
        public void TestDiv()
        {
            int result = Program.Div(12, 2);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void TestDivFail()
        {
            Assert.Throws<DivideByZeroException>(() => JenkinsTP.Program.Div(6, 0));
        }
    }
}

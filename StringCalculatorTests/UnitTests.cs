using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculatorKata;

namespace StringCalculatorTests
{
    [TestClass]
    public class UnitTests
    {
        Program program;

        [TestInitialize]
        public void setUp()
        {
            program = new Program();
        }

        [TestMethod]
        public void TestEmptyString()
        {
            int result = program.Add("");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestOneElementString()
        {
            int result = program.Add("1");

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestTwoElementString()
        {
            int result = program.Add("1,2");

            Assert.AreEqual(3, result);
        }
    }
}

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
        public void emptyStringTest()
        {
            int result = program.Add("");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void oneElementStringTest()
        {
            int result = program.Add("1");

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void twoElementStringTest()
        {
            int result = program.Add("1,2");

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void newSeparatorTest()
        {
            int result = program.Add("1\n2,3");

            Assert.AreEqual(6, result);
        }
    }
}

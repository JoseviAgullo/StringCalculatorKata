using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculatorKata;

namespace StringCalculatorTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void FirstTest()
        {
            Program program = new Program();

            int result = program.Add("");

            Assert.AreEqual(0, result);
        }
    }
}

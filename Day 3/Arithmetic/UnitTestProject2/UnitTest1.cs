using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double test1 = 1;
            double test2 = 2;
            double result = Arithmetic.Program.sum(test1, test2);
            Assert.IsTrue(result == 3);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int test1 = 1;
            int test2 = 2;
            int answer = sum(test1, test2);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTestingUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = CalculatorTestingExample.Operations.Add(1, 3);
            Assert.IsTrue(result == 4);

            var result2 = CalculatorTestingExample.Operations.Subtract(1, 3);
            Assert.IsTrue(result2 == -2);
        }
    }
}

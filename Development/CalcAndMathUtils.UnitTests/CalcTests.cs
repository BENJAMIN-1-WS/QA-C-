using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalcAndMathUtils.UnitTests
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calc calculator = new Calc();

            int actual = calculator.add(1, 2);

            Assert.AreEqual(3, actual);
        }
    }
}

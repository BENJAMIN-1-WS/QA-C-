using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DevelopmentProj.UnitTests
{
    [TestClass]
    public class SimpleTestMethod
    {
        [TestMethod]
        public void SimpleTest1()
        {

            const int ten = 10; //In the coming future we will trigger a development code from here

            Assert.AreEqual(10, ten, "We should have get 10 as a result");
            //Assert.IsTrue(10 == ten);
            //Assert.IsFalse(!(10 == ten));

        }


        [TestMethod]
        public void SimpleTest2()
        {

            const int ten = 10; //In the coming future we will trigger a development code from here

            //Assert.AreEqual(10, ten);
            Assert.IsTrue(10 == ten, "We should have get 10 as a result");
            //Assert.IsFalse(!(10 == ten));

        }


        [TestMethod]
        [DataRow(20, 20)]
        [DataRow(2, 2)]
        public void TestSomeNumbers(int firstNum, int secondNum)
        {
            Assert.AreEqual(firstNum , secondNum, "Error messsage");
        }










    }
}

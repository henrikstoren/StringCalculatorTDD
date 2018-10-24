using System;
using StringCalculatorTDDWorkshop;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculatorTestProject
{
    [TestClass]
    public class StringCalculatorTests
    {
        StringCalculator calculator = new StringCalculator();

        [TestMethod]
        public void CheckIfAddMethodExsists()
        {
            calculator.Add("");
        }

        [TestMethod]
        public void AddEmptyReturnsZero()
        {
            Assert.AreEqual(0, calculator.Add(""));
        }

        [TestMethod]
        public void AddOneReturnsOne()
        {
            Assert.AreEqual(1, calculator.Add("1"));
        }

        [TestMethod]
        public void AddTwoReturnsTwo()
        {
            Assert.AreEqual(2, calculator.Add("2"));
        }

        [TestMethod]
        public void AddThreeReturnsThree()
        {
            Assert.AreEqual(3, calculator.Add("3"));
        }

        [TestMethod]
        public void AddTwoNumbers()
        {
            Assert.AreEqual(3, calculator.Add("1,2"));
        }

        [TestMethod]
        public void AddTwoNumbers2()
        {
            Assert.AreEqual(5, calculator.Add("1,4"));
        }

        [TestMethod]
        public void AddThreeNumbers()
        {
            Assert.AreEqual(260, calculator.Add("1,25,234"));
        }

        [TestMethod]
        public void AddGreaterThanThousandIgnoresIt()
        {
            Assert.AreEqual(342, calculator.Add("2,340,1005"));
        }

        [TestMethod]
        public void SpesificSeparatorAdd()
        {
            Assert.AreEqual(17, calculator.Add("//[,,,]\n3,,,9,,,5"));
        }

        [TestMethod]
        public void MultipleSeparatorAdd()
        {
            Assert.AreEqual(17, calculator.Add("//[%][*]\n3%9*5"));
        }

        [TestMethod]
        public void MultipleSeparatorWithBracketsAdd()
        {
            Assert.AreEqual(19, calculator.Add("//[[]][*]\n3[]9*7"));
        }
    }
}

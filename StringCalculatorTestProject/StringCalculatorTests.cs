using System;
using StringCalculatorTDDWorkshop;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculatorTestProject
{
    [TestClass]
    public class StringCalculatorTests
    {
        [TestMethod]
        public void CheckIfAddMethodExsists()
        {
            var calculator = new StringCalculator();
            calculator.Add("");
        }
    }
}

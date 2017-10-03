using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using StringCalculatorProgram;

namespace StringCalculatorTests
{
    [TestClass]
    public class StringCalculatorTests
    {
        [TestMethod]
        public void AddEmptyString()
        {
            StringCalculator calculator = new StringCalculator();
            string numbers = "";
            Assert.AreEqual(0, calculator.Add(numbers));
        }

        [TestMethod]
        public void AddOneNumber()
        {
            StringCalculator calculator = new StringCalculator();
            string numbers = "1";
            Assert.AreEqual(1, calculator.Add(numbers));
        }

        [TestMethod]
        public void AddTwoNumbers()
        {
            StringCalculator calculator = new StringCalculator();
            string numbers = "1,2";
            Assert.AreEqual(3, calculator.Add(numbers));
        }

        [TestMethod]
        public void AddThreeNumbers()
        {
            StringCalculator calculator = new StringCalculator();
            string numbers = "1,5,7";
            Assert.AreEqual(13, calculator.Add(numbers));
        }

        [TestMethod]
        public void AddFourNumbers()
        {
            StringCalculator calculator = new StringCalculator();
            string numbers = "1,10,11,3";
            Assert.AreEqual(25, calculator.Add(numbers));
        }

        [TestMethod]
        public void AddNewLineNumbers()
        {
            StringCalculator calculator = new StringCalculator();
            string numbers = "1\n2,3";
            Assert.AreEqual(6, calculator.Add(numbers));
        }

        [TestMethod]
        public void AddNewLineNumbers_2()
        {
            StringCalculator calculator = new StringCalculator();
            string numbers = "3\n5\n2,4";
            Assert.AreEqual(14, calculator.Add(numbers));
        }

        [TestMethod]
        public void AddDelimeters()
        {
            StringCalculator calculator = new StringCalculator();
            string numbers = "//;\n1;2";
            Assert.AreEqual(3, calculator.Add(numbers));
        }
    }
}

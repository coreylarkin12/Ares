using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class KataRomanNumeralsTests
    {
        // Same thing goes for the code these past but I'm pretty sure I may be missing some tests and 
        // may have done these incorrectly. 

        [TestMethod]
        public void RomanNumTest_1()
        {
            Dictionary<int, string> romanTest = new Dictionary<int, string>();

            Assert.AreEqual(romanTest.ContainsKey(1), romanTest.ContainsValue("I"));
            
        }

        [TestMethod]
        public void RomanNumTest_4()
        {
            Dictionary<int, string> romanTest = new Dictionary<int, string>();

            Assert.AreEqual(romanTest.ContainsKey(4), romanTest.ContainsValue("IV"));

        }

        [TestMethod]
        public void RomanNumTest_5()
        {
            Dictionary<int, string> romanTest = new Dictionary<int, string>();

            Assert.AreEqual(romanTest.ContainsKey(5), romanTest.ContainsValue("V"));

        }
        [TestMethod]
        public void RomanNumTest_9()
        {
            Dictionary<int, string> romanTest = new Dictionary<int, string>();

            Assert.AreEqual(romanTest.ContainsKey(9), romanTest.ContainsValue("IX"));

        }
        [TestMethod]
        public void RomanNumTest_10()
        {
            Dictionary<int, string> romanTest = new Dictionary<int, string>();

            Assert.AreEqual(romanTest.ContainsKey(10), romanTest.ContainsValue("X"));

        }
        [TestMethod]
        public void RomanNumTest_40()
        {
            Dictionary<int, string> romanTest = new Dictionary<int, string>();

            Assert.AreEqual(romanTest.ContainsKey(40), romanTest.ContainsValue("XL"));

        }
        [TestMethod]
        public void RomanNumTest_50()
        {
            Dictionary<int, string> romanTest = new Dictionary<int, string>();

            Assert.AreEqual(romanTest.ContainsKey(50), romanTest.ContainsValue("L"));

        }
        [TestMethod]
        public void RomanNumTest_90()
        {
            Dictionary<int, string> romanTest = new Dictionary<int, string>();

            Assert.AreEqual(romanTest.ContainsKey(90), romanTest.ContainsValue("XC"));

        }
        [TestMethod]
        public void RomanNumTest_100()
        {
            Dictionary<int, string> romanTest = new Dictionary<int, string>();

            Assert.AreEqual(romanTest.ContainsKey(100), romanTest.ContainsValue("C"));

        }
        [TestMethod]
        public void RomanNumTest_400()
        {
            Dictionary<int, string> romanTest = new Dictionary<int, string>();

            Assert.AreEqual(romanTest.ContainsKey(400), romanTest.ContainsValue("CD"));

        }
        [TestMethod]
        public void RomanNumTest_500()
        {
            Dictionary<int, string> romanTest = new Dictionary<int, string>();

            Assert.AreEqual(romanTest.ContainsKey(500), romanTest.ContainsValue("D"));

        }
        [TestMethod]
        public void RomanNumTest_900()
        {
            Dictionary<int, string> romanTest = new Dictionary<int, string>();

            Assert.AreEqual(romanTest.ContainsKey(900), romanTest.ContainsValue("CM"));

        }
        [TestMethod]
        public void RomanNumTest_1000()
        {
            Dictionary<int, string> romanTest = new Dictionary<int, string>();

            Assert.AreEqual(romanTest.ContainsKey(1000), romanTest.ContainsValue("M"));

        }
    }
}

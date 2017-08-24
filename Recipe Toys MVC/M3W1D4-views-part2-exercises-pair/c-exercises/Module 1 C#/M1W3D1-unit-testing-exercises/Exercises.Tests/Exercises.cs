using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;


namespace Exercises.Tests
{
    [TestClass]
    public class ExerciseTests
    {
        Exercises exercises = new Exercises();

        [TestMethod]
        public void AnimalGroupName()
        {
            Assert.AreEqual("Tower", exercises.GetHerd("giraffe"));
            Assert.AreEqual("unknown", exercises.GetHerd(""));
            Assert.AreEqual("unknown", exercises.GetHerd("walrus"));
            Assert.AreEqual("Crash", exercises.GetHerd("RHINO"));
            Assert.AreEqual("Crash", exercises.GetHerd("Rhino"));
            Assert.AreEqual("unknown", exercises.GetHerd("elephants"));
        }

        [TestMethod]
        public void CigarParty()
        {
            Assert.AreEqual(false, exercises.HaveParty(30, false), "Input: HaveParty (30, false)");
            Assert.AreEqual(true, exercises.HaveParty(50, false), "Input: HaveParty (50, false)");
            Assert.AreEqual(true, exercises.HaveParty(70, true), "Input: HaveParty (70, true");
        }

        [TestMethod]
        public void Lucky13()
        {
            Assert.AreEqual(true, exercises.GetLucky(new int[] { 0, 2, 4 }), "Input was [0, 2, 4]");
            Assert.AreEqual(false, exercises.GetLucky(new int[] { 1, 2, 3 }), "Input was [1, 2, 3]");
            Assert.AreEqual(false, exercises.GetLucky(new int[] { 1, 2, 4 }), "Input was [1, 2, 4]");
           
        }

        [TestMethod]
        public void MaxEnd3()
        {
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, exercises.MakeArray(new int[] { 1, 2, 3 }), "Input was [1, 2, 3]");
            CollectionAssert.AreEqual(new int[] { 11, 11, 11 }, exercises.MakeArray(new int[] { 11, 5, 9 }), "Input was [11, 5, 9]");
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, exercises.MakeArray(new int[] { 2, 11, 3 }), "Input was [2, 11, 3]");
        }

        [TestMethod]
        public void NonStart()
        {
            Assert.AreEqual("ellohere", exercises.GetPartialString("Hello", "There"));
            Assert.AreEqual("avaode", exercises.GetPartialString("java", "code"));
            Assert.AreEqual("hot1ava", exercises.GetPartialString("shot1", "java"));
        }

        [TestMethod]
        public void SameFirstLast()
        {
            Assert.AreEqual(false, exercises.IsItTheSame(new int[] { 1, 2, 3 }), "Input was [1, 2, 3]");
            Assert.AreEqual(true, exercises.IsItTheSame(new int[] { 1, 2, 3, 1 }), "Input was [1, 2, 3, 1]");
            Assert.AreEqual(true, exercises.IsItTheSame(new int[] { 1, 2, 1 }), "Input was [1, 2, 1]");
        }

        [TestMethod]
        public void StringBits()
        {
            Assert.AreEqual("Hlo", exercises.GetBits("Hello"));
            Assert.AreEqual("H", exercises.GetBits("Hi"));
            Assert.AreEqual("Hello", exercises.GetBits("Heeololeo"));
        }

        [TestMethod] 
        public void WordCount()
        {
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"ba", 2 },
                {"black", 1 },
                {"sheep", 1 }
            };
            Dictionary<string, int> actual = exercises.GetCount(new string[] { "ba", "ba", "black", "sheep" });
            AssertCollections(expected, actual);

            expected = new Dictionary<string, int>()
            {
                {"b", 2 },
                {"c", 1 },
                {"a", 2 }
            };
            actual = exercises.GetCount(new string[] { "a", "b", "a", "c", "b" });
            AssertCollections(expected, actual);

            expected = new Dictionary<string, int>()
            {
            };
            actual = exercises.GetCount(new string[] { });
            AssertCollections(expected, actual);

            expected = new Dictionary<string, int>()
            {
                {"b", 1 },
                {"c", 1 },
                {"a", 1 }
            };
            actual = exercises.GetCount(new string[] { "c", "b", "a" });
            AssertCollections(expected, actual);

        }
        private void AssertCollections(Dictionary<string, string> expected, Dictionary<string, string> actual)
        {
            foreach (KeyValuePair<string, string> kvp in expected)
            {
                if (!actual.ContainsKey(kvp.Key))
                {
                    Assert.Fail();
                }
                Assert.AreEqual(kvp.Value, actual[kvp.Key]);
            }
        }
        private void AssertCollections(Dictionary<string, int> expected, Dictionary<string, int> actual)
        {
            foreach (KeyValuePair<string, int> kvp in expected)
            {
                if (!actual.ContainsKey(kvp.Key))
                {
                    Assert.Fail();
                }
                Assert.AreEqual(kvp.Value, actual[kvp.Key]);
            }
        }
    }
}

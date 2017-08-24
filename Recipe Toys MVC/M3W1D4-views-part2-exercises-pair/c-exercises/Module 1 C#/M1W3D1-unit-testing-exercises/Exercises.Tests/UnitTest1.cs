using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class ExerciseTests
    {
        Exercises exercises = new Exercises();

        [TestMethod]
        public void animalGroupName()
        {
            Assert.AreEqual("Tower", exercises.AnimalGroupName("giraffe"));
            Assert.AreEqual("unknown", exercises.AnimalGroupName(" "));
            Assert.AreEqual("unknown", exercises.AnimalGroupName("walrus"));
            Assert.AreEqual("Crash", exercises.AnimalGroupName("RHINO"));
            Assert.AreEqual("Crash", exercises.AnimalGroupName("Rhino"));
            Assert.AreEqual("unknown", exercises.AnimalGroupName("elephants"));
        }
    }
}

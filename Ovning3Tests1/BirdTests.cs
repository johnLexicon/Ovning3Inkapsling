using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ovning3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3.Tests
{
    [TestClass()]
    public class BirdTests
    {
        [TestMethod()]
        public void StatsTest()
        {
            // Arrange
            Bird bird = new Bird();
            int expectedAge         = bird.Age      = 1;
            string expectedName     = bird.Name     = "Pippi";
            int expectedWeight      = bird.Weight   = 2;
            int expectedWingSpan    = bird.WingSpan = 5;

            // Act
            int actualAge       = bird.Age;
            string actualName   = bird.Name;
            int actualWeight    = bird.Weight;
            int actualWingSpan  = bird.WingSpan;

            // Assert
            Assert.AreEqual(expectedAge, actualAge);
            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedWeight, actualWeight);
            Assert.AreEqual(expectedWingSpan, actualWingSpan);
        }
    }
}
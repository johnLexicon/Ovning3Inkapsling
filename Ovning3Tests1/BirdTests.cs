using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        [TestMethod()]
        public void StatsTestNotEqual()
        {
            // Arrange
            Bird bird = new Bird();
            bird.Age = 1;
            bird.Name = "Pippi";
            bird.Weight = 2;
            bird.WingSpan = 5;

            int expectedAge = 2;
            string expectedName = "Sune";
            int expectedWeight = 3;
            int expectedWingSpan = 6;

            // Act
            int actualAge = bird.Age;
            string actualName = bird.Name;
            int actualWeight = bird.Weight;
            int actualWingSpan = bird.WingSpan;

            // Assert
            Assert.AreNotEqual(expectedAge, actualAge);
            Assert.AreNotEqual(expectedName, actualName);
            Assert.AreNotEqual(expectedWeight, actualWeight);
            Assert.AreNotEqual(expectedWingSpan, actualWingSpan);
        }
    }
}
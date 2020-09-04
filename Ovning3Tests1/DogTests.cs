using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ovning3
{
    [TestClass()]
    public class DogTests
    {
        [TestMethod()]
        public void IqTest()
        {
            // Arrange
            int expected = 10;

            // Act
            Dog dog = new Dog();
            dog.Iq = 10;
            int actual = dog.Iq;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void StatsTest()
        {
            // Arrange
            Dog dog = new Dog();
            dog.Name = "Kurt";
            dog.Weight = 20;
            dog.Age = 10;
            dog.Iq = 15;
            string expected = "Name: Kurt, Age: 10, Weight: 20, IQ: 15";

            // Act
            string actual = dog.Stats();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void StatsTestFail()
        {
            // Arrange
            Dog dog = new Dog();
            dog.Name = "Kurt";
            dog.Weight = 200; // Wrong
            dog.Age = 10;
            dog.Iq = 15;
            string expected = "Name: Kurt, Age: 10, Weight: 20, IQ: 15";

            // Act
            string actual = dog.Stats();

            // Assert
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod()]
        public void returnStringTest()
        {
            // Arrange
            Dog dog = new Dog();
            string expected = "Detta är lite text";

            // Act
            string actual = dog.returnString();

            // Assert
            Assert.AreEqual(expected, actual);
        }  
    }
}
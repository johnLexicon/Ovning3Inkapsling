using Microsoft.VisualStudio.TestPlatform.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System;

namespace Ovning3
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void TestCorrectFirstName()
        {
            // Arrange
            string firstName = "Stefan";
            Person person = new Person(firstName, "Elmgren");
            var expected = "Stefan";

            // Act
            person.FName = firstName;
            string actual = person.FName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void TestFirstNameTooShortThrowsArgumentException()
        {
            // Arrange
            string firstName = "S";
            Person person = new Person(firstName, "Elmgren");
            Exception exception = null;

            // Act
            try
            {
                person.FName = firstName; //This should throw an exception
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            // Assert - Expects exception
        }
    }
}

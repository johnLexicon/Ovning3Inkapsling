using OvningssamlingInkapslingArvOchPolymorfism;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System;

namespace OvningssamlingInkapslingArvOchPolymorfismTests
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
        public void TestFirstNameTooShortThrowsArgumentException()
        {
            // Arrange
            string firstName = "S";
            Person person = new Person(firstName, "Elmgren");
            Exception exception = null;
            string expected = "First name should contain between two and ten letters!";
            string expected2 = null;

            // Act
            try
            {
                person.FName = firstName; //This should throw exeption
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            string actual = exception.Message;
            string actual2 = null;

            // Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);
        }
    }
}

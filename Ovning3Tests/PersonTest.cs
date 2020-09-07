using Microsoft.VisualStudio.TestPlatform.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System;
using Ovning3;

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
        [ExpectedException(typeof(System.ArgumentException))] 
        public void TestFirstNameTooShortThrowsArgumentException()
        {
            // Arrange
            string firstName = "S";
            Person person = new Person(firstName, "Elmgren");
            //Exception exception = null;

            // Act
            //try
            //{
            //    person.FName = firstName; //This should throw an exception
            //}
            //catch (Exception ex)
            //{
            //    exception = ex;
            //}

            //While using the attribute you only need to run the code that throws the exception without using try-catch.
            person.FName = firstName;
            
            // Assert - Expects exception
        }
    }
}

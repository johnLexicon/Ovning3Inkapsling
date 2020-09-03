using Microsoft.VisualStudio.TestTools.UnitTesting;
using OvnSamlingInkapslArvOPolym;
using System;
using System.Collections.Generic;
using System.Text;

namespace OvnSamlingInkapslArvOPolym.Tests
{
    [TestClass()]
    public class PersonHandlerTests
    {
        [TestMethod()]
        public void SetFirstNameTest()
        {
            // Arrange
            Person person;
            int expected = 54;

            // Act
            person = PersonHandler.CreatePerson(53, "Stefan", "Elmgren", 180, 83);
            PersonHandler.SetAge(person, 54);
            int actual = person.Age;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SetLastNameTest()
        {
            // Arrange
            Person person;
            string expected = "Larsson";

            // Act
            person = PersonHandler.CreatePerson(53, "Stefan", "Elmgren", 180, 83);
            PersonHandler.SetLastName(person, "Larsson");
            string actual = person.LName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SetAgeTest()
        {
            // Arrange
            Person person;
            string expected = "Sune";

            // Act
            person = PersonHandler.CreatePerson(53, "Stefan", "Elmgren", 180, 83);
            PersonHandler.SetFirstName(person, "Sune");
            string actual = person.FName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SetHeightTest()
        {
            // Arrange
            Person person;
            int expected = 175;

            // Act
            person = PersonHandler.CreatePerson(53, "Stefan", "Elmgren", 180, 83);
            PersonHandler.SetHeight(person, 175);
            int actual = person.Height;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SetWeightTest()
        {
            // Arrange
            Person person;
            double expected = 83.1;

            // Act
            person = PersonHandler.CreatePerson(53, "Stefan", "Elmgren", 180, 83);
            PersonHandler.SetWeight(person, 83.1);
            double actual = person.Weight;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CreatePersonTest()
        {
            // Arrange
            Person person;
            string expected = "Stefan Elmgren 53 180 83";

            // Act
            person = PersonHandler.CreatePerson(53, "Stefan", "Elmgren", 180, 83);
            string actual = $"{person.FName} {person.LName} {person.Age} {person.Height} {person.Weight}";

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ovning3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3.Tests
{
    [TestClass()]
    public class NumericInputErrorTests
    {
        [TestMethod()]
        public void UEMessageTest()
        {
            // Arrange
            NumericInputError numericInputError = new NumericInputError();
            string expected = "You tried to use a numeric input in a text only field.This fired an error!";

            // Act
            string actual = numericInputError.UEMessage();           

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
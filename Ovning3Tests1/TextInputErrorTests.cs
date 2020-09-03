using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ovning3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3.Tests
{
    [TestClass()]
    public class TextInputErrorTests
    {
        [TestMethod()]
        public void UEMessageTest()
        {
            // Arrange
            TextInputError textInputError = new TextInputError();
            string expected = "You tried to use a text input in a numericonly field. This fired an error!";

            // Act
            string actual = textInputError.UEMessage();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
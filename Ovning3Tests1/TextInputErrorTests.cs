using Microsoft.VisualStudio.TestTools.UnitTesting;

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
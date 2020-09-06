using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ovning3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3.Tests
{
    [TestClass()]
    public class HedgehogTests
    {
        [TestMethod()]
        public void SpikeTest()
        {
            // Arrange
            Hedgehog hedgehog = new Hedgehog();
            hedgehog.NrOfSpikes = 55;
            int expected = 55;

            // Act
            int actual = hedgehog.NrOfSpikes;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void StatsTest()
        {
            // Arrange
            Hedgehog hedgehog = new Hedgehog();
            hedgehog.NrOfSpikes = 666;
            string expected = "Name: , Age: 0, Weight: 0, Number of spikes: 666";


            // Act
            string actual = hedgehog.Stats();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
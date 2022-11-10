using Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class FindTopValuesTests
    {
        private FindTopValues systemUnderTest;

        [TestInitialize]
        public void TestSetup()
        {
            systemUnderTest = new FindTopValues();
        }

        [TestMethod]
        public void FindMaxValue_ReturnsCorrectInteger()
        {
            // Arrange
            int[] numbers = { 5, 10, 50, 500, 1000 };

            // Act
            var highestNumber = systemUnderTest.FindTopNValues(numbers);

            // Assert
            Assert.AreEqual(1000, highestNumber);
        }

        [TestMethod]
        public void FindMaxValue_ReturnsCorrectInteger_WhenNegativeNumbersIncluded()
        {
            // Arrange
            int[] numbers = { 50, 10, -50, 500, -1000 };

            // Act
            var highestNumber = systemUnderTest.FindTopNValues(numbers);

            // Assert
            Assert.AreEqual(500, highestNumber);
        }

        [TestMethod]
        public void FindTopNValues_ReturnsCorrectArray()
        {
            // Arrange
            int[] numbers = { 5, 10, 50, 500, 1000 };

            // Act
            var actualTopNValues = systemUnderTest.FindTopNValues(numbers, 2);
            int[] expectedTopNValues = { 1000, 500 };

            // Assert
            CollectionAssert.AreEqual(expectedTopNValues, actualTopNValues);
        }

        [TestMethod]
        public void FindTopNValues_ReturnsCorrectArray_WhenNegativeNumbersIncluded()
        {
            // Arrange
            int[] numbers = { 50, 10, -50, 500, -1000 };

            // Act
            var actualTopNValues = systemUnderTest.FindTopNValues(numbers, 2);
            int[] expectedTopNValues = { 500, 50 };

            // Assert
            CollectionAssert.AreEqual(expectedTopNValues, actualTopNValues);
        }
    }
}
using Xunit;
using AlgosLib;

namespace AlgosLibTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestArraySort()
        {
            // Arrange
            int[] testArray = new int[] { 36, 1, 25, 42, 20, 9, 7 };

            // Act
            int[] expected = new int[] { 1, 7, 9, 20, 25, 36, 42 };
            int[] actual = Class1.SortArray(testArray);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestArraySearch()
        {
            // Arrange
            int[] testArray = new int[] { 36, 1, 25, 42, 20, 9, 7 };

            // Act
            int expected = 4;
            int actual = Class1.SearchArray(25, testArray);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 36, 1, 25, 42, 20, 9, 7 })] // Arrange
        public void TestArraySearch1(int[] testArray)
        {
            // Act
            int expected = 4;
            int actual = Class1.SearchArray(25, testArray);

            // Assert
            Assert.True(expected == actual);
        }

        [Fact]
        public void TestFibonacci()
        {
            // Arrange
            int n = 3;

            // Act
            int expected = 2;
            int actual = Class1.Fibonacci(n);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}

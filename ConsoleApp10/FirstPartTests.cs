using Xunit;

namespace Task01.Tests
{
    public class FirstPartTests
    {
        // Тестирование конструктора класса на создание объекта с некорректными значениями
        [Theory]
        [InlineData(0)]
        [InlineData(-10)]
        public void Test_IsWrongLengthVectorCreatingFailed(int length)
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new FirstPart(length));
        }

        // Тестирование метода GetSumOfNegativeElements
        [Fact]
        public void Test_GetSumOfNegativeElements()
        {
            // Arrange
            var firstPart = new FirstPart(5);
            firstPart.SetVector(new[] { 1, -2, 3, -4, 5 });
            int expected = -6; // -2 + (-4) = -6

            // Act
            int result = firstPart.GetSumOfNegativeElements();

            // Assert
            Assert.Equal(expected, result);
        }

        // Тестирование метода GetMultiplicationBetweenMinMax
        [Fact]
        public void Test_GetMultiplicationBetweenMinMax()
        {
            // Arrange
            var firstPart = new FirstPart(5);
            firstPart.SetVector(new[] { 2, -5, 3, -8, 1 });
            int expected = -8; // min: -8, max: 3, -8 * 3 = -24

            // Act
            int result = firstPart.GetMultiplicationBetweenMinMax();

            // Assert
            Assert.Equal(expected, result);
        }

        // Тестирование метода SortByDescending
        [Fact]
        public void Test_SortByDescending()
        {
            // Arrange
            var firstPart = new FirstPart(5);
            firstPart.SetVector(new[] { 3, -1, 0, 4, -2 });
            var expected = new[] { 4, 3, 0, -1, -2 };

            // Act
            firstPart.SortByDescending();
            var result = firstPart.GetVector();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}

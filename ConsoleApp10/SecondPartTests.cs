using Xunit;

namespace Task01.Tests
{
    public class SecondPartTests
    {
        // Тестирование метода GetColsWithoutZerosCount
        [Fact]
        public void Test_GetColsWithoutZerosCount()
        {
            // Arrange
            var secondPart = new SecondPart(4, 5);
            int[,] matrix = new int[,]
            {
                { 1, 0, 3, 0, 5 },
                { 0, 0, 0, 0, 0 },
                { 0, 2, 0, 4, 0 },
                { 0, 0, 0, 0, 0 }
            };
            int expected = 2; // Ожидаемое количество столбцов без нулей

            // Act
            int result = secondPart.GetColsWithoutZerosCount(matrix);

            // Assert
            Assert.Equal(expected, result); // Проверка равенства ожидаемого и фактического результата
        }

        // Тестирование метода GetMatrixOrderedByCharacteristics
        [Fact]
        public void Test_GetMatrixOrderedByCharacteristics()
        {
            // Arrange
            var secondPart = new SecondPart(4, 5);
            int[,] matrix = new int[,]
            {
                { 1, -2, 3, 0, 5 },
                { 0, 0, 0, 0, 0 },
                { -1, 2, 0, 4, 0 },
                { 0, 0, 0, 0, 0 }
            };
            int[,] expected = new int[,]
            {
                { -2, -1, 0, 0, 0 },
                { 2, 1, 0, 0, 0 },
                { 0, 0, 3, 4, 5 },
                { 0, 0, 0, 0, 0 }
            }; // Ожидаемая матрица после сортировки по характеристикам

            // Act
            int[,] result = secondPart.GetMatrixOrderedByCharacteristics(matrix);

            // Assert
            Assert.Equal(expected, result); // Проверка равенства ожидаемого и фактического результата
        }
    }
}


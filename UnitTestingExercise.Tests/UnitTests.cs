using UnitTestingExercise;
using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(3, 3, 5, 11)]
        [InlineData(5, 3, 5, 13)]
        [InlineData(15, -5, 2, 12)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator plus = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            var actual = plus.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 5, -5)]//Add test data <-------
        [InlineData(5, 5, 0)]
        [InlineData(2, 5, -3)]
        [InlineData(9, 1, 8)]
        [InlineData(5, 2, 3)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator minus = new Calculator();

            //Act
            var actual = minus.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(actual, expected);

        }

        [Theory]
        [InlineData(1, 0, 0)]//Add test data <-------
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 4)]
        [InlineData(-5, 2, -10)]
        [InlineData(11, -5, -55)]
        [InlineData(5, 5, 25)]
        [InlineData(0, 5, 0)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator multiplier = new Calculator();

            //Act
            var actual = multiplier.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,1)]//Add test data <-------
        [InlineData(9, 3, 3)]
        [InlineData(25, 5, 5)]
        [InlineData(15, 5, 3)]
        [InlineData(99, 9, 11)]
        [InlineData(5.5, 5, 1.1)]
        [InlineData(5, 0, -1)]
        public void DivideTest(decimal num1, decimal num2, decimal expected)
        {
            //Arrange
            Calculator divider = new Calculator();

            //Act
            var actual = divider.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}

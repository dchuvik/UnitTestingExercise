using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var sum = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = sum.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 6, 4)]//Add test data <-------
        [InlineData(200, 70, 130)]
        [InlineData(77, 11, 66)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var difference = new Calculator();
            //Act
            var actual = difference.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 25)]//Add test data <-------
        [InlineData(10, 10, 100)]
        [InlineData(10, 6, 60)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var product = new Calculator();
            //Act
            var actual = product.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(100, 2, 50)]//Add test data <-------
        [InlineData(10, 2, 5)]
        [InlineData(1000, 4, 250)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var quotient = new Calculator();
            //Act
            var actual = quotient.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}

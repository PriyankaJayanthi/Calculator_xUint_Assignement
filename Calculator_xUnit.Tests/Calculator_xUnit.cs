using System;
using Xunit;
using Calculator_xUnit_Assignement;

namespace calculator_xUnit.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Addition_simplecalculation()
        {
            //Arrange
            double[] array = { 4, 25, 8 };
            double expected = 37;
            //Act
            double actual = calculatorTest.Addition(array);
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Subtraction_simplecalculation()
        {
            //Arrange
            double[] array = { -12, 3, -24, 4 };
            double expected = 29;
            //Act
            double actual = calculatorTest.Subtraction(array);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Multiplication_simplevalue()
        {
            //Arrange
            double expected = 15;
            //Act
            double actual = calculatorTest.Multiplication(5, 3);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Division_simplevalue()
        {
            //Arrange
            double expected = 2;
            //Act
            double actual = calculatorTest.Division(10, 5);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Division_exception()
        {
            //Arrange
            double expected = 0;
            //Act
            double actual = calculatorTest.Division(4, 0);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(7.5, 12.4, 93)]
        [InlineData(5, 1.3, 6.5)]
        public void Multiplication_doublenum(double x, double y, double expected)
        {
            double actual = calculatorTest.Multiplication(x, y);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(20, 100, 0.2)]
        public void Division_doublenum(double x, double y, double expected)
        {
            double actual = calculatorTest.Division(x, y);
            Assert.Equal(expected, actual);

        }
    }
}
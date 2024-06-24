using Calculator.Model.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests.Model.Operations
{
    public class DivisionTests
    {
        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(10, -2, -5)]
        [InlineData(-10, 2, -5)]
        [InlineData(-10, -2, 5)]
        [InlineData(0, 2, 0)]
        [InlineData(10.5, 2, 5.25)]
        [InlineData(10, 0.5, 20)]
        public void Execute_DividesNumbers_CorrectResult(decimal firstArg, decimal secondArg, decimal expected)
        {
            // Arrange
            var division = new Division();

            // Act
            decimal result = division.Execute(firstArg, secondArg);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Execute_DivideByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            var division = new Division();
            decimal firstArg = 10;
            decimal secondArg = 0;

            // Act 
            var exception = Assert.Throws<DivideByZeroException>(() => division.Execute(firstArg, secondArg));
            //Assert
            Assert.Equal("Nie można dzielić przez zero", exception.Message);
        }
        [Fact]
        public void Properties_AreCorrect()
        {
            // Arrange
            var division = new Division();

            // Act
            string name = division.Name;
            string symbol = division.Symbol;

            // Assert
            Assert.Equal("Division", name);
            Assert.Equal("/", symbol);
        }
    }
}

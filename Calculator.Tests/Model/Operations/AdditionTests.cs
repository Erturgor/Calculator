using Calculator.Model.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests.Model.Operations
{
    public class AdditionTests
    {
        [Fact]
        public void Execute_AddsNumbers_CorrectResult()
        {
            // Arrange
            var addition = new Addition();
            decimal firstArg = 10;
            decimal secondArg = 20;
            decimal expected = 30;

            // Act
            decimal result = addition.Execute(firstArg, secondArg);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}

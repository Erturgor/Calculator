using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Model;
using Calculator.ViewModel;

namespace Calculator.Tests.ViewModel
{
    using Model;
    public class CalculatingTests
    {
        [Fact]
        public void Execute_CallsCalculatorExecuteOperationBySymbol_WithCorrectParameters()
        {
            // Arrange
            var mockCalculator = new Mock<ICalculator>();
            mockCalculator.Setup(c => c.ExceuteOperationBySymbol("+", 5, 3)).Returns(8);

            var calculating = new Calculating(mockCalculator.Object);

            // Act
            var result = calculating.Execute("+", 5, 3);

            // Assert
            Assert.Equal(8, result);
            mockCalculator.Verify(c => c.ExceuteOperationBySymbol("+", 5, 3), Times.Once);
        }

        [Fact]
        public void Execute_ThrowsException_WhenSymbolNotFound()
        {
            // Arrange
            var mockCalculator = new Mock<ICalculator>();
            mockCalculator.Setup(c => c.ExceuteOperationBySymbol("*", 5, 3)).Throws(new Exception("Brak operacji o podanym symbolu"));

            var calculating = new Calculating(mockCalculator.Object);

            // Act & Assert
            var exception = Assert.Throws<Exception>(() => calculating.Execute("*", 5, 3));
            Assert.Equal("Brak operacji o podanym symbolu", exception.Message);
            mockCalculator.Verify(c => c.ExceuteOperationBySymbol("*", 5, 3), Times.Once);
        }

        [Fact]
        public void Execute_ThrowsArgumentNullException_WhenCalculatorIsNull()
        {
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new Calculating(null));
        }
    }
}

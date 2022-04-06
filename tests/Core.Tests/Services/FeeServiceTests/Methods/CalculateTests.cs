using System;
using Xunit;

namespace Core.Tests.Services.FeeServiceTests.Methods
{
    public class CalculateTests : FeeServiceTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void InvalidValorInicial_ThrowsArgumentException(decimal valorInicial)
        {
            #region Arrange
            var juros = 0.1;
            var meses = 1;
            #endregion

            // Act
            var result = Record.Exception(() => _sut.Calculate(valorInicial, juros, meses));

            // Assert
            Assert.NotNull(result);
            Assert.IsType<ArgumentException>(result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-0.1)]
        public void InvalidJuros_ThrowsArgumentException(double juros)
        {
            #region Arrange
            var valorInicial = 1m;
            var meses = 1;
            #endregion

            // Act
            var result = Record.Exception(() => _sut.Calculate(valorInicial, juros, meses));

            // Assert
            Assert.NotNull(result);
            Assert.IsType<ArgumentException>(result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void InvalidMeses_ThrowsArgumentException(int meses)
        {
            #region Arrange
            var valorInicial = 1m;
            var juros = 1.0;
            #endregion

            // Act
            var result = Record.Exception(() => _sut.Calculate(valorInicial, juros, meses));

            // Assert
            Assert.NotNull(result);
            Assert.IsType<ArgumentException>(result);
        }

        [Theory]
        [InlineData(100, 0.01, 5, 105.1)]
        [InlineData(100, 1, 1, 200)]
        public void ValidInput_ReturnsCorrectCalculatedFee(decimal valorInicial, double juros, int meses, decimal montante)
        {
            // Act
            var result = _sut.Calculate(valorInicial, juros, meses);

            // Assert
            Assert.IsType<decimal>(result);
            Assert.Equal(montante, result);
        }
    }
}

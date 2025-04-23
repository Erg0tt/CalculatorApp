using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ReturnsCorrectResult()
        {
            int result = Calculator.Add(3, 5);
            Assert.Equal(8, result);
        }

        [Fact]
        public void Subtract_ReturnsCorrectResult()
        {
            int result = Calculator.Subtract(10, 4);
            Assert.Equal(6, result);
        }
    }
}

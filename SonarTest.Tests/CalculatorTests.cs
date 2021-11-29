using Xunit;

namespace SonarTest.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_WhenCalled_ReturnsAdditionOfInput()
        {
            var result = Calculator.Add(1, 1);
            
            Assert.Equal(2, result);
        }

        [Fact]
        public void Subtract_WhenCalled_ReturnsSubtractionOfInput()
        {
            var result = Calculator.Subtract(2, 1);
            
            Assert.Equal(1, result);
        }
    }
}
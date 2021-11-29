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
    }
}
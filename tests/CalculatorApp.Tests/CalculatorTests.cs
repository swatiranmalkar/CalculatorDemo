using CalculatorApp;
using Xunit;

namespace CalculatorApp.Tests;

public class CalculatorTests
{
    private readonly Calculator _calculator = new();

    // [Fact] = a single test with fixed values.
    [Fact]
    public void Add_TwoPositiveNumbers_ReturnsSum()
    {
        // Arrange (set up) - done above with _calculator
        // Act (call the method)
        int result = _calculator.Add(2, 3);

        // Assert (check the result)
        Assert.Equal(5, result);
    }

    // [Theory] = the same test run several times with different data.
    [Theory]
    [InlineData(10, 4, 6)]
    [InlineData(0, 5, -5)]
    [InlineData(-3, -3, 0)]
    public void Subtract_ReturnsDifference(int a, int b, int expected)
    {
        Assert.Equal(expected, _calculator.Subtract(a, b));
    }

    [Theory]
    [InlineData(3, 4, 12)]
    [InlineData(7, 0, 0)]
    [InlineData(-2, 5, -10)]
    public void Multiply_ReturnsProduct(int a, int b, int expected)
    {
        Assert.Equal(expected, _calculator.Multiply(a, b));
    }

    [Fact]
    public void Divide_ValidNumbers_ReturnsQuotient()
    {
        Assert.Equal(4, _calculator.Divide(20, 5));
    }

    [Fact]
    public void Divide_ByZero_ThrowsException()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
    }
}

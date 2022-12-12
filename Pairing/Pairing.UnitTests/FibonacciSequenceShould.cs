using Moq;
using Pairing.Logging;
using Xunit;

namespace Pairing.UnitTests;

public class FibonacciSequenceShould
{
    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(4, 3)]
    [InlineData(5, 5)]
    [InlineData(6, 8)]
    public void ReturnNthNumber_GivenPositiveInput(int nthNumber, int expectedResult)
    {
        // Assemble
        var mockLogger = new Mock<ILogger>();
        var fib = new FibonacciSequence(mockLogger.Object);

        // Act
        var actualResult = fib.Find(nthNumber);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void LogInput_GivenPositiveInput()
    {
        // Assemble
        var mockLogger = new Mock<ILogger>();

        // Act
        var fib = new FibonacciSequence(mockLogger.Object);

        // Assert
    }
}
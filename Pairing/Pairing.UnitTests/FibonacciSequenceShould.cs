using Xunit;

namespace Pairing.UnitTests;

public class FibonacciSequenceShould
{
    [Fact]
    public void ReturnNthNumber_GivenPositiveInput()
    {
        // Assemble
        var fib = new FibonacciSequence();

        // Act
        var actualResult = fib.Find(???);

        // Assert
        Assert.Equal(???, actualResult);
    }
}
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
        var fib = new FibonacciSequence();

        var actualResult = fib.Find(nthNumber);

        Assert.Equal(expectedResult, actualResult);
    }
}
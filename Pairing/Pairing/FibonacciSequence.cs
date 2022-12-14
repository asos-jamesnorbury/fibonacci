using System;
using Pairing.Logging;

namespace Pairing;

public class FibonacciSequence
{
    private readonly ILogger _logger;

    public FibonacciSequence(ILogger logger)
    {
        _logger = logger;
    }

    public int Find(int nthNumber)
    {
        Console.WriteLine($"Finding fibonacci number: {nthNumber}");

        var result = CalculateNumber(nthNumber);

        Console.WriteLine($"Result: {result}");

        return result;
    }

    private int CalculateNumber(int nthNumber)
    {
        if (nthNumber == 1)
        {
            return 1;
        }
        else if (nthNumber == 0)
        {
            return 0;
        }

        return Find(nthNumber - 1) + Find(nthNumber - 2);
    }
}

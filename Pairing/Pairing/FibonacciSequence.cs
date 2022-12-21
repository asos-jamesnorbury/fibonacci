namespace Pairing;

public class FibonacciSequence
{
    public int Find(int nthNumber)
    {
        var result = CalculateNumber(nthNumber);

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

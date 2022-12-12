using System;

namespace Pairing.Logging;

public class ConsoleLogger : ILogger
{
    public void LogInformation(string message)
    {
        Console.WriteLine(message);
    }
}

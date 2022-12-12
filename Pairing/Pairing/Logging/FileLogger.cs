using System.IO;

namespace Pairing.Logging;

public class FileLogger : ILogger
{
    private readonly string _path = "log.txt";

    public void LogInformation(string message)
    {
        File.AppendAllText(_path, message);
    }
}

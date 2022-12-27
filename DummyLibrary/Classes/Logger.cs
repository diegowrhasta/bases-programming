using DummyLibrary.Interface;

namespace DummyLibrary.Classes;

public class Logger : ILogger
{
    public void Info(string message)
    {
        Console.WriteLine($"Logging [INFO] - {message}");
    }

    public void Error(string message, Exception exception)
    {
        Console.WriteLine($"Logging [ERROR] - {message} ; {exception.Message}");
    }

    public void Debug(string message)
    {
        Console.WriteLine($"Logging [DEBUG] - {message}");
    }
}
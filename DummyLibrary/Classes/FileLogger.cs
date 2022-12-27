using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class FileLogger : ILogger
{
    public void LogMessage(string stackTrace)
    {
        // Code to log stack trace into a file.
    }
}
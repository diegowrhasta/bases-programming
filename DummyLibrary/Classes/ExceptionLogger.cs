using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class ExceptionLogger
{
    private ILogger _logger;

    public ExceptionLogger(ILogger logger)
    {
        _logger = logger;
    }

    public void LogException(Exception exception)
    {
        var message = GetUserReadableMessage(exception);
        _logger.LogMessage(message);
    }

    private string GetUserReadableMessage(Exception exception)
    {
        var message = string.Empty;

        // Code to convert the exception's stack trace and message to user readable format.

        return message;
    }
}
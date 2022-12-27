namespace DummyLibrary.Classes;

public class ExceptionLogger
{
    public void LogIntoFile(Exception exception)
    {
        var fileLogger = new FileLogger();
        fileLogger.LogMessage(GetUserReadableMessage(exception));
    }
    
    public void LogIntoDataBase(Exception exception)
    {
        var fileLogger = new DbLogger();
        fileLogger.LogMessage(GetUserReadableMessage(exception));
    }

    private string GetUserReadableMessage(Exception exception)
    {
        var message = string.Empty;

        // Code to convert the exception's stack trace and message to user readable format.

        return message;
    }
}
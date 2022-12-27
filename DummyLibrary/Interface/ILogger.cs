namespace DummyLibrary.Interface;

public interface ILogger
{
    void Info(string message);
    void Error(string message, Exception exception);
    void Debug(string message);
}
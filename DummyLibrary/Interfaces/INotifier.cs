namespace DummyLibrary.Interfaces;

public interface INotifier
{
    void Send(string subject, string message);
}
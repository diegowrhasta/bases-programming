using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class EmailNotifier : INotifier
{
    public void Send(string subject, string message)
    {
        Console.WriteLine("Sending Email...");
        Console.WriteLine($"Subject: {subject}");
        Console.WriteLine($"Message: {message}");
    }
}
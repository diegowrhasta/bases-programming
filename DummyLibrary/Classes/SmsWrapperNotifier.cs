using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class SmsWrapperNotifier : Decorator
{
    public SmsWrapperNotifier(INotifier notifier) : base(notifier)
    {
    }

    public override void Send(string subject, string message)
    {
        base.Send(subject, message);
        Console.WriteLine("\nSending SMS...");
        Console.WriteLine($"Subject: {subject}");
        Console.WriteLine($"Message: {message}");
    }
}
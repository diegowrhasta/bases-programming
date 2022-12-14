using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class SmokeWrapperNotifier : Decorator
{
    public SmokeWrapperNotifier(INotifier notifier) : base(notifier)
    {
    }

    public override void Send(string subject, string message)
    {
        base.Send(subject, message);
        Console.WriteLine("\nSending Smoke Signals...");
        Console.WriteLine($"Subject: {TranslateToSignal(subject)}");
        Console.WriteLine($"Message: {TranslateToSignal(message)}");
    }

    private static string TranslateToSignal(string stringToConvert)
    {
        var splitted = stringToConvert.Split(" ");
        return splitted.Length == 0 ? "." : new string('x', splitted.Length);
    }
}
using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public abstract class Decorator : INotifier
{
    internal readonly INotifier Notifier;

    protected Decorator(INotifier notifier)
    {
        Notifier = notifier;
    }

    public virtual void Send(string subject, string message) => Notifier.Send(subject, message);
}
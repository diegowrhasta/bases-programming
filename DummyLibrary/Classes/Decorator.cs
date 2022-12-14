using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public abstract class Decorator : INotifier
{
    private readonly INotifier _notifier;

    protected Decorator(INotifier notifier)
    {
        _notifier = notifier;
    }

    public virtual void Send(string subject, string message) => _notifier.Send(subject, message);
}
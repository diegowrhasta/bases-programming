using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class Publisher
{
    private IList<ISubscriber> _subscribers = new List<ISubscriber>();
    public void Subscribe(ISubscriber subscriber) => _subscribers.Add(subscriber);
    public void Unsubscribe(ISubscriber subscriber) => _subscribers.Remove(subscriber);

    public void Notify(EventType eventType)
    {
        var subsForEvent = _subscribers
            .Where(s => eventType == EventType.All || s.EventType == eventType);
        foreach (var subscriber in subsForEvent)
        {
            subscriber.Update($"{nameof(Publisher)} - Event: {eventType}, I did something, guys!");
        }
    }
}
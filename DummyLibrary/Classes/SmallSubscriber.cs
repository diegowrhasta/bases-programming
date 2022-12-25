using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class SmallSubscriber : ISubscriber
{
    public EventType EventType { get; set; }
    public void Update(string message)
    {
        Console.WriteLine("The Small Subscriber has been notified of an update. Message is:");
        Console.WriteLine(message);
    }
}
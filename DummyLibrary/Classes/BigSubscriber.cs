using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class BigSubscriber : ISubscriber
{
    public EventType EventType { get; set; }

    public void Update(string message)
    {
        Console.WriteLine("The Big Subscriber has been notified of an update. Message is:");
        Console.WriteLine(message);
    }
}
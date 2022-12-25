using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class MediumSubscriber : ISubscriber
{
    public EventType EventType { get; set; }

    public void Update(string message)
    {
        Console.WriteLine("The Medium Subscriber has been notified of an update. Message is:");
        Console.WriteLine(message);
    }
}
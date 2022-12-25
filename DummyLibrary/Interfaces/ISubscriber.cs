using DummyLibrary.Classes;

namespace DummyLibrary.Interfaces;

public interface ISubscriber
{
    EventType EventType { get; set; }
    void Update(string message);
}
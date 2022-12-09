using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class Plane : ITransport
{
    public void TransportStuff()
    {
        Console.WriteLine("I am a plane transporting...");
    }
}
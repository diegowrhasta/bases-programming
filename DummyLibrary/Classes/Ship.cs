using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class Ship : ITransport
{
    public void TransportStuff()
    {
        Console.WriteLine("I am a ship transporting...");
    }
}
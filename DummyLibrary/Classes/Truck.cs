using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class Truck : ITransport
{
    public void TransportStuff()
    {
        Console.WriteLine("I am a truck transporting...");
    }
}
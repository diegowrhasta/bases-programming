// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes;
using DummyLibrary.Interfaces;

Console.WriteLine("Select a ship");
Console.WriteLine("1. Plane");
Console.WriteLine("2. Ship");
Console.WriteLine("3. Truck");

if (!int.TryParse(Console.ReadLine(), out var optionInt))
{
    return;
}


ITransport? transport = optionInt switch
{
    (int)TransportType.Plane => new Plane(),
    (int)TransportType.Truck => new Truck(),
    (int)TransportType.Ship => new Ship(),
    _ => null,
};

if (transport is null)
{
    return;
}

transport.TransportStuff();
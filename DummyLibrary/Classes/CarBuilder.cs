using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class CarBuilder : IBuilder
{
    private Car _car = new();

    public void Reset() => _car = new Car();

    public void SetSeats(int number) => _car.SeatNumber = number;

    public void SetEngine(Engine engine) => _car.Engine = engine;

    public void SetTripComputer(string tripComputer) => _car.TripComputer = tripComputer;

    public void SetGPS() => _car.GPS = "On";

    public Car GetCar() => _car;
}
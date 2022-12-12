using DummyLibrary.Classes;

namespace DummyLibrary.Interfaces;

public interface IBuilder
{
    public void Reset();
    public void SetSeats(int number);
    public void SetEngine(Engine engine);
    public void SetTripComputer(string tripComputer);
    public void SetGPS();
}
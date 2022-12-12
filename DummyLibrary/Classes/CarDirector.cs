using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class CarDirector
{
    private IBuilder _builder;

    public CarDirector(IBuilder builder)
    {
        _builder = builder;
    }

    public void MakeSportsCar()
    {
        _builder.SetEngine(Constants.Engines.SportsEngine);
        _builder.SetSeats(2);
        _builder.SetTripComputer("Cheap Trip Computer");
    }

    public void MakeVintageCar()
    {
        _builder.SetEngine(Constants.Engines.VintageEngine);
        _builder.SetSeats(4);
        _builder.SetTripComputer("Cheap Trip Computer");
    }
}
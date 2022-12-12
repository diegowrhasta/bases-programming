using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class Director
{
    private IBuilder _builder;

    public Director(IBuilder builder)
    {
        _builder = builder;
    }

    public void MakeSportsCar()
    {
        var engine = new Engine
        {
            Displacement = 9.6f,
            Type = "V12",
            Weight = 980,
            PowerOutput = 180,
            BoreAndStroke = "4 1/8 X 5 1/2",
        };

        _builder.SetEngine(engine);
        _builder.SetSeats(2);
        _builder.SetTripComputer("Cheap Trip Computer");
    }

    public void MakeVintageCar()
    {
        var engine = new Engine
        {
            Displacement = 0.80f,
            Type = "Single-cylinder",
            Weight = 310,
            PowerOutput = 15,
            BoreAndStroke = "4 1/8 X 5 1/2",
        };

        _builder.SetEngine(engine);
        _builder.SetSeats(4);
        _builder.SetTripComputer("Cheap Trip Computer");
    }

    public void ChangeBuilder(IBuilder builder) => _builder = builder;
}
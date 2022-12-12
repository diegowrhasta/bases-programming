using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class FlyerDirector
{
    private IFlyerBuilder _builder;

    public FlyerDirector(IFlyerBuilder builder)
    {
        _builder = builder;
    }

    public void MakeNormalFlyer()
    {
        var message = "Please buy our cars, please!" +
                      $"\nVintage Cars, Sports Cars. Really cheap!";
        _builder.SetMessage(message);
        _builder.SetSize("Normal");
    }

    public void MakeBigFlyer()
    {
        var message = "Please buy our cars, please!" +
                      $"\nVintage Cars, Sports Cars. Really cheap!" +
                      $"\nEngines amongst:\n" +
                      $"{Constants.Engines.SportsEngine}\n\n" +
                      $"{Constants.Engines.VintageEngine}";
        _builder.SetMessage(message);
        _builder.SetSize("Big");
    }
}
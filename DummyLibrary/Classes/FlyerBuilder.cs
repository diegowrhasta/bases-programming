using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class FlyerBuilder : IFlyerBuilder
{
    private Flyer _flyer = new();

    public void Reset() => _flyer = new Flyer();

    public void SetMessage(string message) => _flyer.Message = message;

    public void SetSize(string size) => _flyer.Size = size;

    public Flyer GetFlyer()
    {
        var finalFlyer = _flyer;
        _flyer = new Flyer();
        return finalFlyer;
    }
}
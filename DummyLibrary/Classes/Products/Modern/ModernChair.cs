using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes.Products.Modern;

public class ModernChair : IChair
{
    public bool IsSquare { get; set; }

    public void SitOn()
    {
        var propertyMessage = IsSquare ? "It is also square" : "It is not square";
        Console.WriteLine("Sitting on a Modern Chair, so artsy...");
        Console.WriteLine(propertyMessage);
    }
}
using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes.Products.Victorian;

public class VictorianChair : IChair
{
    public bool IsSquare { get; set; }

    public void SitOn()
    {
        var propertyMessage = IsSquare ? "It is also square" : "It is not square";
        Console.WriteLine("Sitting on a Victorian Chair, so vintage...");
        Console.WriteLine(propertyMessage);
    }
}
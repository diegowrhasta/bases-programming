using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes.Products.Art_Deco;

public class ArtDecoChair : IChair
{
    public bool IsSquare { get; set; } = true;
    public bool IsLong { get; set; }

    public void SitOn()
    {
        var propertyMessage = IsSquare ? "It is also square" : "It is not square";
        Console.WriteLine("Sitting on an Art Deco Chair, so artsy...");
        Console.WriteLine(propertyMessage);
    }
}
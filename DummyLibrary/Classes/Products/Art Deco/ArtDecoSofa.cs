using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes.Products.Art_Deco;

public class ArtDecoSofa : ISofa
{
    public bool IsSquare { get; set; }
    public bool IsLong { get; set; } = true;

    public void SitOn()
    {
        var propertyMessage = IsLong ? "It is also long" : "It is not long";
        Console.WriteLine("Sitting on an Art Deco Sofa, so artsy...");
        Console.WriteLine(propertyMessage);
    }
}
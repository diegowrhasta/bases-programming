using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes.Products.Victorian;

public class VictorianSofa : ISofa
{
    public bool IsLong { get; set; }

    public void SitOn()
    {
        var propertyMessage = IsLong ? "It is also long" : "It is not long";
        Console.WriteLine("Sitting on a Victorian Sofa, so modern...");
        Console.WriteLine(propertyMessage);
    }
}
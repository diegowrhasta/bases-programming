using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes.Products.Modern;

public class ModernSofa : ISofa
{
    public bool IsLong { get; set; }

    public void SitOn()
    {
        var propertyMessage = IsLong ? "It is also long" : "It is not long";
        Console.WriteLine("Sitting on a Modern Sofa, so modern...");
        Console.WriteLine(propertyMessage);
    }
}
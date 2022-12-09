using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes.Products.Modern;

public class ModernCoffeeTable : ICoffeeTable
{
    public bool IsSquare { get; set; }
    public bool IsLong { get; set; }

    public void SitOn()
    {
        var propertyMessage = IsSquare ? "It is also square" : "It is not square";
        var property2Message = IsLong ? "It is also long" : "It is not long";
        Console.WriteLine("Sitting on a Modern Coffee Table, so modern...");
        Console.WriteLine(propertyMessage);
        Console.WriteLine(property2Message);
    }
}
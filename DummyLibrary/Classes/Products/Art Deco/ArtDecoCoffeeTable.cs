using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes.Products.Art_Deco;

public class ArtDecoCoffeeTable : ICoffeeTable
{
    public bool IsSquare { get; set; } = true;
    public bool IsLong { get; set; } = true;

    public void SitOn()
    {
        var propertyMessage = IsSquare ? "It is also square" : "It is not square";
        var property2Message = IsLong ? "It is also long" : "It is not long";
        Console.WriteLine("Sitting on an Art Deco Coffee Table, so artsy...");
        Console.WriteLine(propertyMessage);
        Console.WriteLine(property2Message);
    }
}
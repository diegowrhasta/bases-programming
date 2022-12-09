using DummyLibrary.Classes.Products.Modern;
using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes.Factories;

public class ModernFactory : IProductFactory
{
    public IChair CreateChair() => new ModernChair();

    public ICoffeeTable CreateCoffeeTable() => new ModernCoffeeTable();

    public ISofa CreateSofa() => new ModernSofa();
}
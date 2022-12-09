using DummyLibrary.Classes.Products.Victorian;
using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes.Factories;

public class VictorianFactory : IProductFactory
{
    public IChair CreateChair() => new VictorianChair();

    public ICoffeeTable CreateCoffeeTable() => new VictorianCoffeeTable();

    public ISofa CreateSofa() => new VictorianSofa();
}
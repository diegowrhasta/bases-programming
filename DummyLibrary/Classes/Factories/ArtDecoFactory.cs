using DummyLibrary.Classes.Products.Art_Deco;
using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes.Factories;

public class ArtDecoFactory : IProductFactory
{
    public IChair CreateChair() => new ArtDecoChair();

    public ICoffeeTable CreateCoffeeTable() => new ArtDecoCoffeeTable();

    public ISofa CreateSofa() => new ArtDecoSofa();
}
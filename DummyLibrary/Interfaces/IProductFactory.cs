namespace DummyLibrary.Interfaces;

public interface IProductFactory
{
    public IChair CreateChair();
    public ICoffeeTable CreateCoffeeTable();
    public ISofa CreateSofa();
}
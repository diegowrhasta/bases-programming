namespace DummyLibrary.Interfaces;

public interface IIngredient
{
    string Name { get; set; }
    decimal Cost { get; set; }
    public int Units { get; set; }
    decimal GetCost();
}
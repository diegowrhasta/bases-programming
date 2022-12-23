using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes.Ingredients;

public class RedPepper : IIngredient
{
    public string Name { get; set; } = "Red Pepper";
    public decimal Cost { get; set; } = 12;
    public int Units { get; set; }

    public decimal GetCost()
    {
        var cost = Cost * Units;
        Console.WriteLine($"{Units} {Name}(s) requested. Cost: {cost:C2}");

        return cost;
    }
}
using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes.Ingredients;

public class Garlic : IIngredient
{
    public string Name { get; set; } = "Garlic";
    public decimal Cost { get; set; } = 2;
    public int Units { get; set; }

    public decimal GetCost()
    {
        var cost = Cost * Units;
        Console.WriteLine($"{Units} {Name}(s) requested. Cost: {cost:C2}");

        return cost;
    }
}
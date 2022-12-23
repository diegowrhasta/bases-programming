using DummyLibrary.Interfaces;
using DummyLibrary.Models;

namespace DummyLibrary.Classes.Ingredients;

public class ChickenBreast : IIngredient
{
    public string Name { get; set; } = "Chicken Breast";
    public decimal Cost { get; set; } = 3;
    public int Units { get; set; }

    public decimal GetCost()
    {
        var cost = Cost * Units;
        Console.WriteLine($"{Units} {Name}(s) requested. Cost: {cost:C2}");

        return cost;
    }
}
namespace DummyLibrary.Classes;

public abstract class Ingredient
{
    public abstract string Name { get; set; }
    public abstract decimal Cost { get; set; }
    public abstract int Units { get; set; }

    public virtual decimal GetCost()
    {
        var cost = Cost * Units;
        Console.WriteLine($"{Units} {Name}(s) requested. Cost: {cost:C2}");

        return cost;
    }
}
namespace DummyLibrary.Classes;

public class HumansAi : GameAi
{
    protected override void CollectResources()
    {
        Console.WriteLine("Humans collect a lot, adding 1000 Resources");
        Resources += 1000;
    }

    protected override void BuildStructures()
    {
        Console.WriteLine("Humans build a lot, adding 10 Structures");
        Structures += 10;
    }

    protected override void BuildUnits()
    {
        Console.WriteLine("Humans train a lot of units, adding 20 Warriors, and 10 Scouts");
        Warriors += 20;
        Scouts += 10;
    }

    protected override void Attack() => Console.WriteLine("The Humans Attack!");

    protected override void Taunt() => Console.WriteLine("Human Lord: May this fight cleanse this land. Attack!");
}
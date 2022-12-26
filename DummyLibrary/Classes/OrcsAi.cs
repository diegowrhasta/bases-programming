namespace DummyLibrary.Classes;

public class OrcsAi : GameAi
{
    protected override void CollectResources()
    {
        Console.WriteLine("Orcs collect little, adding 100 Resources");
        Resources += 100;
    }

    protected override void BuildStructures()
    {
        Console.WriteLine("Orcs build a lot, adding 20 Structures");
        Structures += 20;
    }

    protected override void BuildUnits()
    {
        Console.WriteLine("Orcs train few but strong of units, adding 5 Warriors, and 2 Scouts");
        Warriors += 5;
        Scouts += 2;
    }

    protected override void Attack() => Console.WriteLine("The Orcs Attack!");

    protected override void Taunt() => Console.WriteLine("Orc Warchief: Feel the wrath of the Horde. Attack!");
}
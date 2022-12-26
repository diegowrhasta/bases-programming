using DummyLibrary.Constants;
using DummyLibrary.Interface;

namespace DummyLibrary.Classes;

public class City : INode
{
    private readonly int _citizens = RandomGenerators.Random.Next(1, 1000);

    public void Tax()
    {
        Console.WriteLine($"Taxing the {_citizens} citizens.");

        var roll = RandomGenerators.Random.Next();
        var mood = roll % 2 == 0 ? "happy" : "angry";
        Console.WriteLine($"They are {mood}.");
    }

    public void AcceptVisitor(IVisitor visitor) => visitor.DoWithCity(this);
}
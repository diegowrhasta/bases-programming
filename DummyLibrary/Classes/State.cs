using DummyLibrary.Interface;

namespace DummyLibrary.Classes;

public class State : INode
{
    public int NumberOfMacdonaldRestaurants { get; set; }

    public void BuildNewMacdonald()
    {
        NumberOfMacdonaldRestaurants++;
        Console.WriteLine($"New MC opened, they are now {NumberOfMacdonaldRestaurants}");
    }

    public void AcceptVisitor(IVisitor visitor) => visitor.DoWithState(this);
}
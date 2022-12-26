using DummyLibrary.Interface;

namespace DummyLibrary.Classes;

public class Country : INode
{
    private int _age;

    public string Name { get; init; } = string.Empty;

    public void HaveAnAnniversary()
    {
        _age++;
        Console.WriteLine($"Country {Name}, is now {_age} years old");
    }

    public void AcceptVisitor(IVisitor visitor) => visitor.DoWithCountry(this);
}
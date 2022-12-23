using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes.Ingredients;

public class RedPepper : Ingredient
{
    public override string Name { get; set; } = "Red Pepper";
    public override decimal Cost { get; set; } = 12;
    public override int Units { get; set; }
}
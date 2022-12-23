using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes.Ingredients;

public class Garlic : Ingredient
{
    public override string Name { get; set; } = "Garlic";
    public override decimal Cost { get; set; } = 2;
    public override int Units { get; set; }
}
using DummyLibrary.Interfaces;
using DummyLibrary.Models;

namespace DummyLibrary.Classes.Ingredients;

public class ChickenBreast : Ingredient
{
    public override string Name { get; set; } = "Chicken Breast";
    public override decimal Cost { get; set; } = 3;
    public override int Units { get; set; }
}
using System.Text;
using DummyLibrary.Extensions;
using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class IngredientCache : Ingredient
{
    private readonly IList<Ingredient> _ingredientList = new List<Ingredient>();

    public override string Name { get; set; } = "Ingredient Cache";
    public override decimal Cost { get; set; } = 24;
    public override int Units { get; set; } = 1;

    public override decimal GetCost()
    {
        var cacheCost = Cost * Units;
        Console.WriteLine($"The cache has been received. Cache cost: {cacheCost:C2}");
        var ingredientsCost = _ingredientList.Sum(i => i.GetCost());

        var total = cacheCost + ingredientsCost;
        Console.WriteLine($"Cache total cost (plus ingredients): {total:C2}");
        return total;
    }

    public void AddIngredient(Ingredient ingredient) => _ingredientList.Add(ingredient);
    public void AddIngredients(IEnumerable<Ingredient> ingredient) => _ingredientList.AddRange(ingredient);
    public void RemoveIngredient(Ingredient ingredient) => _ingredientList.Remove(ingredient);
    public void RemoveIngredient(Func<Ingredient, bool> ingredient) => _ingredientList.Remove(ingredient);
}
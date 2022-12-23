using System.Text;
using DummyLibrary.Extensions;
using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class IngredientCache : IIngredient
{
    private readonly IList<IIngredient> _ingredientList = new List<IIngredient>();

    public string Name { get; set; } = "Ingredient Cache";
    public decimal Cost { get; set; } = 24;
    public int Units { get; set; } = 1;

    public decimal GetCost()
    {
        var cacheCost = Cost * Units;
        Console.WriteLine($"The cache has been received. Cache cost: {cacheCost:C2}");
        var ingredientsCost = _ingredientList.Sum(i => i.GetCost());

        var total = cacheCost + ingredientsCost;
        Console.WriteLine($"Cache total cost (plus ingredients): {total:C2}");
        return total;
    }

    public void AddIngredient(IIngredient ingredient) => _ingredientList.Add(ingredient);
    public void AddIngredients(IEnumerable<IIngredient> ingredient) => _ingredientList.AddRange(ingredient);
    public void RemoveIngredient(IIngredient ingredient) => _ingredientList.Remove(ingredient);
    public void RemoveIngredient(Func<IIngredient, bool> ingredient) => _ingredientList.Remove(ingredient);
}
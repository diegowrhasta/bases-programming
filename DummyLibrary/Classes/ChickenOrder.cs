using DummyLibrary.Classes.Ingredients;
using DummyLibrary.Interfaces;
using DummyLibrary.Models;

namespace DummyLibrary.Classes;

public class ChickenOrder : IOrder
{
    private readonly ChickenPayload _payload;

    public ChickenOrder(ChickenPayload payload)
    {
        _payload = payload;
    }

    public void Execute()
    {
        Console.WriteLine("Chicken order received. Preparing...");
        var dishes = new List<IIngredient>();
        for (var i = 0; i < _payload.ChickenDishNumber; i++)
        {
            dishes.Add(GetChickenDishDetails());
        }

        var totalCost = dishes.Sum(d => d.GetCost());
        Console.WriteLine("Order prepared, enjoy!");
        Console.WriteLine($"Don't forget your order amounts to: {totalCost:C2}");
    }

    private static IIngredient GetChickenDishDetails()
    {
        // One chicken dish requires this parameters.
        var ingredientCache = new IngredientCache();

        var chickenBreast = new ChickenBreast
        {
            Units = 3,
        };
        var garlic = new Garlic
        {
            Units = 2,
        };
        var redPepper = new RedPepper
        {
            Units = 2,
        };
        var ingredientList = new List<IIngredient>
        {
            chickenBreast,
            garlic,
            redPepper,
        };

        ingredientCache.AddIngredients(ingredientList);
        return ingredientCache;
    }
}
namespace DummyLibrary.Models;

public class ChickenPayload
{
    public int ChickenDishNumber { get; set; }

    public override string ToString() => $"The amount of Chicken Dishes ordered is: {ChickenDishNumber}";
}
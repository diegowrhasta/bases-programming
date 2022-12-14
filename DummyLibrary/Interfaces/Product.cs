namespace DummyLibrary.Interfaces;

public abstract class Product
{
    internal abstract string ProductName { get; set; }
    internal virtual string CalculationMessage { get; set; } = string.Empty;
    public abstract double TaxRate { get; set; }
    public abstract double UnitCost { get; set; }

    public virtual double CalculatePrice()
    {
        Console.WriteLine($"Calculating Price for {ProductName}.\n");
        Console.WriteLine($"Tax Rate: {TaxRate} %");
        Console.WriteLine($"Unit Cost: {UnitCost} $");
        Console.WriteLine($"Price: {UnitCost * TaxRate} $");

        return TaxRate * UnitCost;
    }
}
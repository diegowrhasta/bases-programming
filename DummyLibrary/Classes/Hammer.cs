using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class Hammer : Product
{
    internal override string ProductName { get; set; } = "Hammer";
    public override double TaxRate { get; set; } = 1.22d;
    public override double UnitCost { get; set; } = 45d;
}
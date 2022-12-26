using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class Calculator
{
    private IStrategy _strategy;

    public Calculator(IStrategy strategy)
    {
        Console.WriteLine($"Calculator started, default strategy: {strategy.GetType().Name}");
        _strategy = strategy;
    }

    public void ChangeStrategy(IStrategy strategy)
    {
        _strategy = strategy;
        Console.WriteLine($"Strategy has been changed! {strategy.GetType().Name}");
    }

    public int ExecuteCalculation(int a, int b)
    {
        Console.WriteLine("Calculating...");

        return _strategy.ExecuteCalculation(a, b);
    }
}
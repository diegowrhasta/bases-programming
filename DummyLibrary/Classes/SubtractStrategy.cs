using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class SubtractStrategy : IStrategy
{
    public int ExecuteCalculation(int a, int b) => a - b;
}
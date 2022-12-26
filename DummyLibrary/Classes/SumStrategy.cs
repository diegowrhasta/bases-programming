using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class SumStrategy : IStrategy
{
    public int ExecuteCalculation(int a, int b) => a + b;
}
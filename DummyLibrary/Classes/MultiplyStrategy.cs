using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class MultiplyStrategy : IStrategy
{
    public int ExecuteCalculation(int a, int b) => a * b;
}
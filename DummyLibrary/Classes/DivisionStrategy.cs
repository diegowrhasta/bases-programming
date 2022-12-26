using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class DivisionStrategy : IStrategy
{
    public int ExecuteCalculation(int a, int b) => a / b;
}
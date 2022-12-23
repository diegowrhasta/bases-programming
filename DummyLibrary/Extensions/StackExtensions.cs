namespace DummyLibrary.Extensions;

public static class StackExtensions
{
    public static Stack<T> FluentPop<T>(this Stack<T> hello)
    {
        hello.Pop();
        return hello;
    }
}
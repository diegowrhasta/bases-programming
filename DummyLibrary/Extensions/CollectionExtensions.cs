namespace DummyLibrary.Extensions;

public static class CollectionExtensions
{
    public static void ForEach<T>(this IEnumerable<T> collection, Action<T> predicate)
    {
        foreach (var t in collection)
        {
            predicate.Invoke(t);
        }
    }
}
namespace DummyLibrary.Extensions;

public static class CollectionExtensions
{
    public static void AddRange<T>(this ICollection<T> collection, IEnumerable<T> newItems)
    {
        foreach (var t in newItems)
        {
            collection.Add(t);
        }
    }

    public static void Remove<T>(this ICollection<T> collection, Func<T, bool> condition)
    {
        var itemsToRemove = collection.Where(condition);
        foreach (var t in itemsToRemove)
        {
            collection.Remove(t);
        }
    }
}
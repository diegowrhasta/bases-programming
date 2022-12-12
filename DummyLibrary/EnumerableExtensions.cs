namespace DummyLibrary;

public static class EnumerableExtensions
{
    public static IEnumerable<T> DeepClone<T>(this IEnumerable<T> collection) where T : ICloneable<T> =>
        collection
            .Select(item => item.DeepClone())
            .ToList();
}
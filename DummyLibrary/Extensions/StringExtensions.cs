namespace DummyLibrary.Extensions;

public static class StringExtensions
{
    public static bool SameAs(this string firstString, string secondString) =>
        string.Equals(firstString, secondString, StringComparison.InvariantCultureIgnoreCase);
}
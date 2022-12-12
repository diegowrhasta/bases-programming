namespace DummyLibrary;

public static class StringExtensions
{
    public static bool SameAs(this string firstString, string secondString) =>
        firstString.Equals(secondString, StringComparison.InvariantCultureIgnoreCase);

    public static bool SameAsSensitive(this string firstString, string secondString) =>
        firstString.Equals(secondString, StringComparison.InvariantCulture);
}
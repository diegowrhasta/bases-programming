namespace DummyLibrary.Extensions;

public static class StringExtensions
{
    public static bool SameAs(this string str1, string str2) =>
        str1.Equals(str2, StringComparison.InvariantCultureIgnoreCase);
}
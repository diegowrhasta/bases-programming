using System.Text;

namespace DummyLibrary.Extensions;

public static class StringBuilderExtensions
{
    public static StringBuilder AppendWhen(
        this StringBuilder builder,
        Func<bool> predicate,
        Func<StringBuilder, StringBuilder> function) =>
        predicate() ? function(builder) : builder;
}
using DummyLibrary;

namespace DummyLibraryTests;

public class UnitTest1
{
    [Fact]
    public void StringExtension_SameAs_ShouldWork()
    {
        const string string1 = "bro";
        const string string2 = "BRO";

        var compare = string1.SameAs(string2);
        Assert.True(compare);
    }

    [Fact]
    public void StringExtension_SameAsSensitive_ShouldWork()
    {
        const string string1 = "bro";
        const string string2 = "BRO";

        var compare = string1.SameAsSensitive(string2);
        Assert.False(compare);
    }
}
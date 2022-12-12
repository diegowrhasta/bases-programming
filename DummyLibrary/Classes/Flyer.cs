using System.Text;

namespace DummyLibrary.Classes;

public class Flyer
{
    public string Message { get; set; } = string.Empty;
    public string Size { get; set; } = "Small";

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();

        stringBuilder.Append($"The size is: {Size}");
        stringBuilder.Append($"\n{Message}");

        return stringBuilder.ToString();
    }
}
using DummyLibrary.Classes.Constants;
using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes.ColorSchemes;

public class RazerScheme : IColorScheme
{
    public string GetPatternMessage() => $"Razer Scheme, the best in the market, Has RGB {HasRgb}, " +
                                         $"Style name: {StyleName}";

    public bool HasRgb { get; set; } = true;
    public StyleName StyleName { get; set; } = StyleName.BigBrother;
}
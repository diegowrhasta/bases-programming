using DummyLibrary.Classes.Constants;
using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes.ColorSchemes;

public class HyperXScheme : IColorScheme
{
    public string GetPatternMessage() => $"HyperX Scheme, the budgetest in the market, Has RGB {HasRgb}, " +
                                         $"Style name: {StyleName}";

    public bool HasRgb { get; set; }
    public StyleName StyleName { get; set; } = StyleName.SadPanda;
}
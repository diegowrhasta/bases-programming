using DummyLibrary.Classes;
using DummyLibrary.Classes.Constants;

namespace DummyLibrary.Interfaces;

public interface IColorScheme
{
    string GetPatternMessage();
    bool HasRgb { get; set; }
    StyleName StyleName { get; set; }
}
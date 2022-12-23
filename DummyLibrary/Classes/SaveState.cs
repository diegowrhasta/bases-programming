using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class SaveState : ICloneable<SaveState>
{
    public string NationName { get; set; } = string.Empty;
    public int AmountOfGold { get; set; }
    public int AmountOfAlies { get; set; }
    public DateTime SaveDate { get; set; } = DateTime.Now;
    public string SaveName { get; set; } = string.Empty;

    public SaveState DeepClone()
    {
        var clone = (SaveState)MemberwiseClone();

        return clone;
    }
}
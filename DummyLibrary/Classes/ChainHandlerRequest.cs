using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class ChainHandlerRequest : ICloneable<ChainHandlerRequest>
{
    public string UserName { get; set; } = string.Empty;
    public string Ip { get; set; } = string.Empty;
    public bool IsQuery { get; set; }
    public decimal Balance { get; set; }

    public ChainHandlerRequest DeepClone()
    {
        var prototype = (ChainHandlerRequest)MemberwiseClone();
        return prototype;
    }
}
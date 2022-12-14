namespace DummyLibrary.Subsystem;

public abstract class Codec
{
    internal readonly float DoubleSeed = (float)new Random().NextDouble();
    public abstract string CodecName { get; set; }
    public abstract float ByteSize { get; set; }
}
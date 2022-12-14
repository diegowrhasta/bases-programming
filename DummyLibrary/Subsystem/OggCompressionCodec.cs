namespace DummyLibrary.Subsystem;

public sealed class OggCompressionCodec : Codec
{
    public OggCompressionCodec()
    {
        ByteSize = (float)(DoubleSeed * (2000d - 1000d) + 1000d);
    }

    public override string CodecName { get; set; } = "Ogg";
    public override float ByteSize { get; set; }
}
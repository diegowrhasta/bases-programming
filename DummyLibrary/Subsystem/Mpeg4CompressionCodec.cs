namespace DummyLibrary.Subsystem;

public sealed class Mpeg4CompressionCodec : Codec
{
    public Mpeg4CompressionCodec()
    {
        ByteSize = (float)(DoubleSeed * (10000d - 5000d) + 5000d);
    }

    public override string CodecName { get; set; } = "mp4";
    public override float ByteSize { get; set; }
}
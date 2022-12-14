namespace DummyLibrary.Subsystem;

public static class CodecFactory
{
    public static Codec? GetCodec(CodecType codecType) => codecType switch
    {
        CodecType.Mpeg4 => new Mpeg4CompressionCodec(),
        CodecType.Ogg => new OggCompressionCodec(),
        _ => null
    };
}
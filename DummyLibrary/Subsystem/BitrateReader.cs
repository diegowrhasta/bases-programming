namespace DummyLibrary.Subsystem;

public class BitrateReader
{
    private byte[] _plainBytes = Array.Empty<byte>();

    public string EncodeVideo(string fileName, Codec codec)
    {
        var fullString = $"{fileName}.{codec.CodecName.ToLower()} - Size: {codec.ByteSize} KB";
        _plainBytes = System.Text.Encoding.UTF8.GetBytes(fullString);

        return Convert.ToBase64String(_plainBytes);
    }
}
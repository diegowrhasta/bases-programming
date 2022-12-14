namespace DummyLibrary.Subsystem;

public class AudioMixer
{
    private byte[] _plainBytes = Array.Empty<byte>();

    public string MixAudio(string encodedVideo)
    {
        _plainBytes = System.Convert.FromBase64String(encodedVideo);

        return System.Text.Encoding.UTF8.GetString(_plainBytes);
    }
}
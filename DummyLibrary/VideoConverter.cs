using DummyLibrary.Subsystem;

namespace DummyLibrary;

public class VideoConverter
{
    private readonly AudioMixer _audioMixer;
    private readonly BitrateReader _bitrateReader;

    public VideoConverter()
    {
        _audioMixer = new AudioMixer();
        _bitrateReader = new BitrateReader();
    }

    public string ConvertVideo(string fileName, CodecType codecType)
    {
        var codec = CodecFactory.GetCodec(codecType);
        if (codec is null)
        {
            throw new ArgumentException($"Codec {codecType} is invalid.");
        }

        var encodedVideo = _bitrateReader.EncodeVideo(fileName, codec);
        var videoWithMixedAudio = _audioMixer.MixAudio(encodedVideo);

        var file = new VideoFile
        {
            Name = $"Conversion finished!\n{videoWithMixedAudio}",
        };

        return file.Name;
    }
}
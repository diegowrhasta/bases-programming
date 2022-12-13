using DummyLibrary.Classes.Constants;
using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes.Devices;

public class Radio : Device
{
    public override float Channel { get; set; } = 60.3f;
    public override int Volume { get; set; } = 50;

    public override float GetChannel() => Channel;

    public override void SetChannel(ChannelOperation channelOperation)
    {
        var random = new Random();
        var channelIncrement = (float)random.NextDouble();
        if (channelOperation is ChannelOperation.ChannelDown)
        {
            channelIncrement *= -1;
        }

        Channel += channelIncrement;
    }
}
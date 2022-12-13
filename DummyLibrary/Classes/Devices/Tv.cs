using DummyLibrary.Classes.Constants;
using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes.Devices;

public class Tv : Device
{
    public override float Channel { get; set; } = 60.3f;
    public override int Volume { get; set; } = 50;

    public override float GetChannel() => (float)Math.Round((decimal)Channel, MidpointRounding.ToZero);

    public override void SetChannel(ChannelOperation channelOperation)
    {
        if (channelOperation is ChannelOperation.ChannelDown)
        {
            Channel -= 1f;
            return;
        }

        Channel += 1f;
    }
}
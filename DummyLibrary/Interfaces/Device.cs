using DummyLibrary.Classes.Constants;

namespace DummyLibrary.Interfaces;

public abstract class Device
{
    public bool IsEnabled { get; set; }
    public virtual int Volume { get; set; }
    public virtual float Channel { get; set; }

    public virtual int GetVolume() => Volume;

    public virtual void SetVolume(VolumeOperation volumeOperation)
    {
        if (volumeOperation is VolumeOperation.Mute)
        {
            Volume = 0;
            return;
        }

        var volumeValue = volumeOperation is VolumeOperation.VolumeUp ? 10 : -10;
        var newVolumeLevel = Volume + volumeValue;
        if (newVolumeLevel < VolumeParameters.MinVolume)
        {
            newVolumeLevel = VolumeParameters.MinVolume;
        }

        Volume += newVolumeLevel;
    }

    public abstract float GetChannel();
    public abstract void SetChannel(ChannelOperation channelOperation);
}
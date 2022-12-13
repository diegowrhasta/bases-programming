using DummyLibrary.Classes.Constants;
using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes.Remotes;

public class AdvancedRemote : Remote
{
    public AdvancedRemote(Device device, IColorScheme colorScheme) : base(device, colorScheme)
    {
    }

    public void Mute() => Device.SetVolume(VolumeOperation.Mute);
}
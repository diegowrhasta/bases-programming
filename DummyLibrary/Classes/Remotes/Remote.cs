using System.Text;
using DummyLibrary.Classes.Constants;
using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes.Remotes;

public class Remote
{
    internal readonly Device Device;
    internal readonly IColorScheme ColorScheme;

    public Remote(Device device, IColorScheme colorScheme)
    {
        Device = device;
        ColorScheme = colorScheme;
    }

    public void TogglePower()
    {
        Device.IsEnabled = !Device.IsEnabled;

        var state = Device.IsEnabled ? "on" : "off";
        var message = $"The devices has been turned {state}.";
        Console.WriteLine(message);
    }

    public void VolumeDown()
    {
        Device.SetVolume(VolumeOperation.VolumeDown);

        var message = $"Volumed reduced: {Device.Volume}";
        Console.WriteLine(message);
    }

    public void VolumeUp()
    {
        Device.SetVolume(VolumeOperation.VolumeUp);

        var message = $"Volumed upped: {Device.Volume}";
        Console.WriteLine(message);
    }

    public void ChannelUp()
    {
        Device.SetChannel(ChannelOperation.ChannelUp);

        var message = $"Channel upped: {Device.Channel}";
        Console.WriteLine(message);
    }

    public void ChannelDown()
    {
        Device.SetChannel(ChannelOperation.ChannelDown);

        var message = $"Channel down: {Device.Channel}";
        Console.WriteLine(message);
    }

    public override string ToString()
    {
        var appender = new StringBuilder();
        appender.Append("Device:\n");
        appender.Append($"\nChannel: {Device.GetChannel()}");
        appender.Append($"\nVolume: {Device.GetVolume()}");
        appender.Append("\nColor Scheme:\n");
        appender.Append("\nColor Scheme:\n");
        appender.Append(ColorScheme.GetPatternMessage());

        return appender.ToString();
    }
}
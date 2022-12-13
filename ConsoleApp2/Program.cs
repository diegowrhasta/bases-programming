// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes.ColorSchemes;
using DummyLibrary.Classes.Devices;
using DummyLibrary.Classes.Remotes;

var radio = new Radio();
var color = new RazerScheme();
var remote = new Remote(radio, color);

remote.ChannelUp();
remote.VolumeDown();
Console.WriteLine(remote.ToString());

var tv = new Tv();
var color2 = new HyperXScheme();
var advancedRemote = new AdvancedRemote(tv, color2);

advancedRemote.Mute();
advancedRemote.ChannelDown();
Console.WriteLine(advancedRemote.ToString());
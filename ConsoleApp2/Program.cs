// See https://aka.ms/new-console-template for more information

using DummyLibrary;
using DummyLibrary.Subsystem;

const string fileName = "brother";
Console.WriteLine("File to convert:");
Console.WriteLine($"Filename: {fileName}\n");
Console.WriteLine("Please select what codec to use:");
Console.WriteLine("1. Ogg");
Console.WriteLine("2. MPEG-4");

if (!int.TryParse(Console.ReadLine(), out var option))
{
    return;
}

var codecType = (CodecType)option;

var videoConverter = new VideoConverter();
var convertedVideo = videoConverter.ConvertVideo(fileName, codecType);
Console.WriteLine(convertedVideo);
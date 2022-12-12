using System.Text;

namespace DummyLibrary.Classes;

public class Car
{
    public int SeatNumber { get; set; }
    public Engine Engine { get; set; } = new();
    public int TireNumber { get; set; } = 4;
    public string TripComputer { get; set; } = string.Empty;
    public string GPS { get; set; } = "Off";

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append("Engine:\n");
        stringBuilder.Append($"{Engine}\n");
        stringBuilder.Append("\nCar:\n");
        stringBuilder.Append($"Seat Number: {SeatNumber}\n");
        stringBuilder.Append($"Tire Number: {TireNumber}\n");
        stringBuilder.Append($"Trip Computer: {TripComputer}\n");
        stringBuilder.Append($"GPS: {GPS}");

        return stringBuilder.ToString();
    }
}
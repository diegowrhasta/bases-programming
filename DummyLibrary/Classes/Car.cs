namespace DummyLibrary.Classes;

public class Car
{
    public int SeatNumber { get; set; }
    public Engine Engine { get; set; } = new();
    public int TireNumber { get; set; }
    public string TripComputer { get; set; } = string.Empty;
    public string GPS { get; set; } = "Off";
}
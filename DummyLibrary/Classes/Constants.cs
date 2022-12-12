namespace DummyLibrary.Classes;

public static class Constants
{
    public static class Engines
    {
        public static readonly Engine SportsEngine = new()
        {
            Displacement = 9.6f,
            Type = "V12",
            Weight = 980,
            PowerOutput = 180,
            BoreAndStroke = "4 1/8 X 5 1/2",
        };

        public static readonly Engine VintageEngine = new()
        {
            Displacement = 0.80f,
            Type = "Single-cylinder",
            Weight = 310,
            PowerOutput = 15,
            BoreAndStroke = "4 1/8 X 5 1/2",
        };
    }
}
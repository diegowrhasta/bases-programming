namespace DummyLibrary.Classes;

public class ApiExploderService
{
    private readonly string _userName;
    private readonly int _shardId;
    private readonly Random _random;
    private const string Dots = "...";

    public ApiExploderService(string userName, int shardId)
    {
        _userName = userName;
        _shardId = shardId;
        _random = new Random();
    }

    public async Task ExplodeMoonAsync()
    {
        Console.WriteLine($"Connecting to terminal {_shardId}, Welcome {_userName}.");
        await Task.Delay(millisecondsDelay: 100);
        Console.WriteLine($"Connection established. Destroying {_shardId}'s Moon");
        await SimulateWaitingAsync();
        Console.WriteLine($"{_shardId}'s Moon Destroyed successfully.");
    }

    private async Task SimulateWaitingAsync()
    {
        var tickNumber = _random.Next(minValue: 1, maxValue: 5);
        for (var i = 0; i < tickNumber; i++)
        {
            Console.WriteLine(Dots);
            var delayRandom = _random.Next(minValue: 1, maxValue: 10) * 100;
            await Task.Delay(millisecondsDelay: delayRandom);
        }
    }
}
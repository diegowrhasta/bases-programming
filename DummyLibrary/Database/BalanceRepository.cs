namespace DummyLibrary.Database;

public static class BalanceRepository
{
    private static IDictionary<string, decimal> _balances = new Dictionary<string, decimal>
    {
        { "diegow", 10000m },
        { "dero", 3556m },
        { "shady", 1m },
        { "moon", 9999m },
        { "jacket", 356m },
    };

    public static decimal GetUserBalance(string userName)
    {
        if (_balances.TryGetValue(userName, out var balance))
        {
            return balance;
        }

        return -1m;
    }
}
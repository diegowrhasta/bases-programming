namespace DummyLibrary;

public class DatabaseConnector
{
    private static readonly Lazy<DatabaseConnector> Lazy = new(() => new DatabaseConnector());
    private readonly IList<string> _databaseConnections = new List<string>();
    private readonly IDictionary<string, bool> _connectionOpen = new Dictionary<string, bool>();

    private DatabaseConnector()
    {
        Console.WriteLine("Initializing database connection...");
        RegisterConnections();
    }

    public static DatabaseConnector GetInstance() => Lazy.Value;

    public void ConnectToDb(string connectionName)
    {
        var connectionFound = _databaseConnections.FirstOrDefault(c => c.SameAs(connectionName));

        if (connectionFound is null)
        {
            throw new ArgumentException($"Connection {connectionFound} not found!");
        }

        var connection = _connectionOpen[connectionFound];
        if (connection)
        {
            throw new InvalidOperationException($"Sorry, {connectionName} is already being used");
        }

        _connectionOpen[connectionFound] = true;
        Console.WriteLine($"Connection established to {connectionFound}");
    }

    public void DisconnectToDb(string connectionName)
    {
        var connectionFound = _databaseConnections.FirstOrDefault(c => c.SameAs(connectionName));

        if (connectionFound is null)
        {
            throw new ArgumentException($"Connection {connectionFound} not found!");
        }

        _connectionOpen[connectionFound] = false;
        Console.WriteLine($"Connection {connectionName} has been cut!");
    }

    private void RegisterConnections()
    {
        _databaseConnections.Add("Con1");
        _databaseConnections.Add("Con2");
        _databaseConnections.Add("Con3");
        _databaseConnections.Add("Con4");
        _databaseConnections.Add("Con5");

        _connectionOpen.Add("Con1", false);
        _connectionOpen.Add("Con2", false);
        _connectionOpen.Add("Con3", false);
        _connectionOpen.Add("Con4", false);
        _connectionOpen.Add("Con5", false);
    }
}
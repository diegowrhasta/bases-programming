namespace DummyLibrary.Classes;

public class ApiExploderServiceAuthService : ApiExploderService
{
    private readonly ApiExploderService _apiExploderService;
    private string[] _acceptedUsers = { "diegow", "dero", "brother" };
    private readonly string _userName;

    public ApiExploderServiceAuthService(
        string userName,
        int shardId)
        : base(userName, shardId)
    {
        _userName = userName;
        _apiExploderService = new ApiExploderService(userName, shardId);
    }

    public new async Task ExplodeMoonAsync()
    {
        if (!CheckAccess(_userName))
        {
            Console.WriteLine($"Sorry {_userName}, you do not have access.");
            return;
        }

        await _apiExploderService.ExplodeMoonAsync();
    }

    private bool CheckAccess(string userName) => _acceptedUsers.Contains(userName);
}
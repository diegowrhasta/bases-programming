// See https://aka.ms/new-console-template for more information

// Case 1 - Direct Contact

using DummyLibrary.Classes;

var chainHandler = new ChainRepositoryQueryHandler();
var response = (OperationResponse)chainHandler.Handle(new ChainHandlerRequest { UserName = "diegow" })!;
ProcessResponse(response);

// Case 2 - Sanitizing
var sanitizingHandler = new ChainSqlInjectionHandler();
var repositoryHandler = new ChainRepositoryQueryHandler();
sanitizingHandler.SetNextHandler(repositoryHandler);

response = (OperationResponse)sanitizingHandler.Handle(new ChainHandlerRequest { UserName = "diegow" })!;
ProcessResponse(response);

// Case 3 - Sanitizing, and IP ban list exception

sanitizingHandler = new ChainSqlInjectionHandler();
repositoryHandler = new ChainRepositoryQueryHandler();
var passwordCrackingHandler = new ChainPasswordCrackingHandler();
sanitizingHandler.SetNextHandler(passwordCrackingHandler);
passwordCrackingHandler.SetNextHandler(repositoryHandler);

response = (OperationResponse)sanitizingHandler.Handle(new ChainHandlerRequest
    { UserName = "helloPeople", Ip = "1.1.1.1" })!;
ProcessResponse(response);

// Case 4 - Sanitizing, IP ban list, Cache
sanitizingHandler = new ChainSqlInjectionHandler();
repositoryHandler = new ChainRepositoryQueryHandler();
passwordCrackingHandler = new ChainPasswordCrackingHandler();
var cacheHandler = new ChainBalanceCacheHandler();
sanitizingHandler.SetNextHandler(passwordCrackingHandler);
passwordCrackingHandler.SetNextHandler(cacheHandler);
cacheHandler.SetNextHandler(repositoryHandler);

response = (OperationResponse)sanitizingHandler.Handle(new ChainHandlerRequest
    { UserName = "helloPeople", Ip = "3.3.3.3", IsQuery = true, })!;
ProcessResponse(response);

// Case 5 - Sanitizing, IP ban list, Cache, Repository

sanitizingHandler = new ChainSqlInjectionHandler();
repositoryHandler = new ChainRepositoryQueryHandler();
passwordCrackingHandler = new ChainPasswordCrackingHandler();
cacheHandler = new ChainBalanceCacheHandler();
sanitizingHandler.SetNextHandler(passwordCrackingHandler);
passwordCrackingHandler.SetNextHandler(cacheHandler);
cacheHandler.SetNextHandler(repositoryHandler);

response = (OperationResponse)sanitizingHandler.Handle(new ChainHandlerRequest { UserName = "moon", Ip = "3.3.3.3", })!;
ProcessResponse(response);

static void ProcessResponse(OperationResponse response)
{
    var balance = decimal.Zero;
    switch (response.Code)
    {
        case 500:
            Console.WriteLine(response.ErrorMessage);
            break;
        case 303:
            balance = (decimal)(response.ResponseData ?? 0m);
            Console.WriteLine($"This is a cached response: Balance is {balance}");
            break;
        default:
            balance = (decimal)(response.ResponseData ?? 0m);
            Console.WriteLine($"Balance is {balance}");
            break;
    }
}
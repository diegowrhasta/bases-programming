// See https://aka.ms/new-console-template for more information

// Case 1 - Direct Contact

using DummyLibrary.Classes;

var chainHandler = new ChainRepositoryQueryHandler();
var response = (OperationResponse)chainHandler.Handle(new ChainHandlerRequest{ UserName = "diegow"})!;
if (response.Code == 500)
{
    Console.WriteLine(response.ErrorMessage);
    return;
}

var balance = (decimal)(response.ResponseData ?? 0m);
Console.WriteLine($"Balance is {balance}");

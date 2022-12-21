using DummyLibrary.Database;

namespace DummyLibrary.Classes;

public class ChainRepositoryQueryHandler : ChainHandler
{
    public override object? Handle(ChainHandlerRequest chainHandlerRequest)
    {
        var balance = BalanceRepository.GetUserBalance(chainHandlerRequest.UserName);
        if (balance < 0)
        {
            return new OperationResponse
            {
                Code = 500,
                ErrorMessage = $"Could not find balance for {chainHandlerRequest.UserName}",
            };
        }

        return new OperationResponse
        {
            Code = 200,
            ResponseData = balance,
        };
    }
}
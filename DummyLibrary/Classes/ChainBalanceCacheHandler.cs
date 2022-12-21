namespace DummyLibrary.Classes;

public class ChainBalanceCacheHandler : ChainHandler
{
    public override object? Handle(ChainHandlerRequest chainHandlerRequest)
    {
        if (chainHandlerRequest.IsQuery)
        {
            return new OperationResponse
            {
                Code = 200,
                ResponseData = 1m,
            };
        }

        return base.Handle(chainHandlerRequest);
    }
}
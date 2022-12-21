namespace DummyLibrary.Classes;

public class ChainBalanceCacheHandler : ChainHandler
{
    public override object? Handle(ChainHandlerRequest chainHandlerRequest)
    {
        if (chainHandlerRequest.IsQuery)
        {
            return new OperationResponse
            {
                Code = 303,
                ResponseData = 404m,
            };
        }

        return base.Handle(chainHandlerRequest);
    }
}
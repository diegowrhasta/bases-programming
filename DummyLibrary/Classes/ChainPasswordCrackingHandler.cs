namespace DummyLibrary.Classes;

public class ChainPasswordCrackingHandler : ChainHandler
{
    private static readonly string[] BannedIps = { "1.1.1.1", "2.2.2.2" };

    public override object? Handle(ChainHandlerRequest chainHandlerRequest)
    {
        if (BannedIps.Contains(chainHandlerRequest.Ip))
        {
            return new OperationResponse
            {
                Code = 500,
                ErrorMessage = "Too many requests, brother",
            };
        }

        return base.Handle(chainHandlerRequest);
    }
}
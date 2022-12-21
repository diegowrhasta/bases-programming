namespace DummyLibrary.Classes;

public class ChainSqlInjectionHandler : ChainHandler
{
    private static readonly string[] InvalidUsernames = { "diegow", "admin", "bro" };

    public override object? Handle(ChainHandlerRequest chainHandlerRequest)
    {
        if (!InvalidUsernames.Contains(chainHandlerRequest.UserName))
        {
            return base.Handle(chainHandlerRequest);
        }

        var sanitizedPayload = chainHandlerRequest.DeepClone();
        sanitizedPayload.UserName = string.Empty;
        return base.Handle(sanitizedPayload);
    }
}
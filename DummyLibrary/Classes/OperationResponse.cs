namespace DummyLibrary.Classes;

public class OperationResponse
{
    public int Code { get; set; }
    public string? ErrorMessage { get; set; }
    public object? ResponseData { get; set; }
}
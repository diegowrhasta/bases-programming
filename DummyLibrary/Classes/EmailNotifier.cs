namespace DummyLibrary.Classes;

public class EmailNotifier
{
    public string Subject { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;

    public void SendEmail()
    {
        Console.WriteLine("Sending Email...");
        Console.WriteLine($"Subject: {Subject}");
        Console.WriteLine($"Message: {Message}");
    }
}
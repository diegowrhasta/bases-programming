using System.Net.Mail;
using DummyLibrary.Interface;

namespace DummyLibrary.Classes;

public class EmailService : IEmailService
{
    public void SendInvoiceEmail(MailMessage mailMessage)
    {
        Console.WriteLine($"Email Service sending... {mailMessage.Body}");
    }
}
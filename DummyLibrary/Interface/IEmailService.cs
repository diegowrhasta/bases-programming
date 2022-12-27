using System.Net.Mail;

namespace DummyLibrary.Interface;

public interface IEmailService
{
    void SendInvoiceEmail(MailMessage mailMessage);
}
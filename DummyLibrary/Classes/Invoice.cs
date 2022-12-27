using System.Net.Mail;
using DummyLibrary.Interface;

namespace DummyLibrary.Classes;

public class Invoice
{
    private readonly ILogger _logger;
    private readonly IEmailService _emailService;

    public Invoice()
    {
        _logger = new Logger();
        _emailService = new EmailService();
    }

    public long InvAmount { get; set; }
    public DateTime InvDate { get; set; }

    public void AddInvoice()
    {
        try
        {
            _logger.Info("Starting Add Invoice");
            // Here we need to write the Code for adding invoice
            // Once the Invoice has been added, then send the  mail
            PrepareEmailForSending();
        }
        catch (Exception ex)
        {
            //Error Logging
            _logger.Error("Error Adding Invoice", ex);
        }
    }

    public void DeleteInvoice()
    {
        try
        {
            _logger.Info("Starting Delete Invoice");
            //Here we need to write the Code for Deleting the already generated invoice
            PrepareEmailForSending();
        }
        catch (Exception ex)
        {
            //Error Logging
            _logger.Error("Error Deleting Invoice", ex);
        }
    }

    private void PrepareEmailForSending()
    {
        _logger.Info("Starting Email Sending");
        var mailMessage = new MailMessage("diegow@gmail.com", "diegow@gmail.com", "EMailSubject", "EMailBody");
        _emailService.SendInvoiceEmail(mailMessage);
    }
}
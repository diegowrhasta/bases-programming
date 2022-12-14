// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes;

var subject = "Test";
var message = "This is a test e-mail";
Console.WriteLine("Sending an email to: Brother\n");

var emailNotifier = new EmailNotifier
{
    Subject = subject,
    Message = message,
};

emailNotifier.SendEmail();
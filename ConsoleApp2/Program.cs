// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes;
using DummyLibrary.Interfaces;

Console.WriteLine("Select the messaging strategy you want.");
Console.WriteLine("1. All: E-mail, SMS, Smoke");
Console.WriteLine("2. Ancient: E-mail, Smoke");
Console.WriteLine("3. Digital: E-mail, SMS");

if (!int.TryParse(Console.ReadLine(), out var option))
{
    return;
}

const string subject = "Test";
const string message = "This is a test e-mail";
var emailNotifier = new EmailNotifier();

Console.WriteLine("Sending an email to: Brother\n");
switch (option)
{
    case (int)MessagingStrategy.All:
        SendAllStrategy(emailNotifier, subject, message);
        break;
    case (int)MessagingStrategy.Ancient:
        SendAncientStrategy(emailNotifier, subject, message);
        break;
    case (int)MessagingStrategy.Digital:
        SendDigitalStrategy(emailNotifier, subject, message);
        break;
}

static void SendAllStrategy(INotifier notifier, string subject, string message)
{
    var smsNotifier = new SmsWrapperNotifier(notifier);
    var smokeNotifier = new SmokeWrapperNotifier(smsNotifier);
    smokeNotifier.Send(subject, message);
}

static void SendAncientStrategy(INotifier notifier, string subject, string message)
{
    var smokeNotifier = new SmokeWrapperNotifier(notifier);
    smokeNotifier.Send(subject, message);
}

static void SendDigitalStrategy(INotifier notifier, string subject, string message)
{
    var smsNotifier = new SmsWrapperNotifier(notifier);
    smsNotifier.Send(subject, message);
}
using DummyLibrary.Classes.Payloads;

namespace DummyLibrary.Classes;

public class EmployeeBenefitsDataViewModel : DataViewModel
{
    public BenefitsPayload PayLoad { get; set; } = new();
    public decimal Total { get; set; } = 234;
    public bool Good { get; set; }

    public void DoLogic()
    {
        var separator = new string('-', 64);
        Console.WriteLine("Benefits View Model");
        Console.WriteLine(separator);
        Mediator!.Send(MediatorEvent.BenefitsRequest);
        Console.WriteLine($"Financial Good? {PayLoad.FinancialGood}");
        Console.WriteLine($"General Views: {PayLoad.GeneralViews}");
    }
}
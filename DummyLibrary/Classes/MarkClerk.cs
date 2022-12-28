using DummyLibrary.Interface;

namespace DummyLibrary.Classes;

public class MarkClerk : IClerk
{
    public string AnswerQuestion(string question)
    {
        Console.WriteLine($"Mark answers the question: {question}");

        return "Yes";
    }

    public void ScanProduct(string product)
    {
        Console.WriteLine($"Mark scans the product: {product}");
    }

    public void BagProduct(string product)
    {
        Console.WriteLine($"Mark bags the product: {product}");
    }

    public void PromptForPayment(string customer)
    {
        Console.WriteLine($"Mark prompts {customer} for the payment.");
    }
}
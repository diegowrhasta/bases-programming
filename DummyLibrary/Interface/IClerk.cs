namespace DummyLibrary.Interface;

/*
 * We rely on contracts, rather than concretions. So we gain the ability to sub in for different possible implementations.
 * Dynamic runtime behavior. Substitutability.
 * Application layer is pure so it can be unit tested.
 * We sub in different objects that follow a contract, but that may as well implement that contract totally differently.
 */
public interface IClerk
{
    string AnswerQuestion(string question);
    void ScanProduct(string product);
    void BagProduct(string product);
    void PromptForPayment(string customer);
}
// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes;
using DummyLibrary.Interface;

var mark = new MarkClerk();
var john = new JohnClerk();

CheckoutCustomer(mark, "bro");
CheckoutCustomer(john, "bro");

void CheckoutCustomer(IClerk clerk, string customer)
{
    clerk.AnswerQuestion("Yes?");
    clerk.ScanProduct("Apple");
    clerk.BagProduct("Apple");
    clerk.PromptForPayment(customer);
}
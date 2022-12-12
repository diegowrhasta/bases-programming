// See https://aka.ms/new-console-template for more information

using DummyLibrary;

var connector = DatabaseConnector.GetInstance();
await Task.Delay(millisecondsDelay: 1000);
connector.ConnectToDb("con1");

await Task.Delay(millisecondsDelay: 1000);
connector.ConnectToDb("con1");
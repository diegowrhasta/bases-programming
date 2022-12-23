// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes;

var entryCollection = new EntryCollection();
var iterator = entryCollection.GetPogoPogoIterator();
var iterator2 = entryCollection.GetEvenIterator();

Console.WriteLine("Pogo Pogo Iteration:");
EntryKiller.KillEntries(iterator);

Console.WriteLine("Even Iteration:");
EntryKiller.KillEntries(iterator2);
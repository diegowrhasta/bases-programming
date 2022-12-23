// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes;

var entryCollection = new EntryCollection();
var iterator = entryCollection.GetPogoPogoIterator();

EntryKiller.KillEntries(iterator);
// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes;

var saveManager = new GameSaveManager();

saveManager.UpdateState();
saveManager.UpdateState();

var save = saveManager.Save("Save 1");
Console.WriteLine($"I have an encrypted backup: {save.GetSaveName()} - {save.GetSaveDate():MM/dd/yyyy hh:mm:ss}");

saveManager.UpdateState();
saveManager.Save("Save 2");
saveManager.Save("Save 3");
save = saveManager.Save("Save 4");
Console.WriteLine($"I have an encrypted backup: {save.GetSaveName()} - {save.GetSaveDate():MM/dd/yyyy hh:mm:ss}");

save = saveManager.RestorePreviousSave();
Console.WriteLine($"I have an encrypted backup: {save.GetSaveName()} - {save.GetSaveDate():MM/dd/yyyy hh:mm:ss}");
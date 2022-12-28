// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes;

var washingMachine = new WashingMachine();

// washingMachine.UpdateClothes(); Is wrong because the access level is private, you can't access it unles from the 
// class itself. That encapsulates that functionality, and also washingMachine._numberOfClothes is illegal, it is 
// a private field, and cannot be accessed from the outside.
washingMachine.WashClothes();

// Encapsulation is this ability/property of knowing what to expose to the outside and what not to, more often than 
// not in order to keep a class working consistently and correctly.
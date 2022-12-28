// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes;
using DummyLibrary.Interfaces;

IExploder orcExploder = new OrcExploder();
orcExploder.ExplodeEntities();

// The client only knows and only cares about the Orc Exploder, exploding Orcs.
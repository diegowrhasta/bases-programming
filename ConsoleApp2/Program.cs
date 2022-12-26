// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes;

GameAi orcs = new OrcsAi();
orcs.TakeTurn();

GameAi humans = new HumansAi();
humans.TakeTurn();

GameAi mobs = new MobAi();
mobs.TakeTurn();
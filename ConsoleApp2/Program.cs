// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes;

var player = new AudioPlayer();
player.ChangeState(new ReadyState(player));
player.ClickPlay();
using DummyLibrary.Extensions;
using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class GameSaveManager
{
    private readonly Random _random = new();

    public SaveState CurrentSaveState { get; set; } = new();
    public Stack<SaveState> StateStack { get; set; } = new();

    public IGameState Save(string saveName)
    {
        var saveStateCopy = CurrentSaveState.DeepClone();
        saveStateCopy.SaveName = saveName;
        StateStack.Push(saveStateCopy);

        return new GameState(saveStateCopy);
    }

    public void Restore(IGameState gameState)
    {
        if (gameState is GameState castedState)
        {
            CurrentSaveState = castedState.GetState();
        }
    }

    public IGameState RestorePreviousSave()
    {
        var previousState = StateStack
            .FluentPop()
            .Pop();
        CurrentSaveState = previousState;

        return new GameState(CurrentSaveState);
    }

    public void UpdateState()
    {
        var roll = _random.Next() % 2 == 0;
        CurrentSaveState.NationName = roll ? "Diego Nation" : "Wacho Nation";
        CurrentSaveState.SaveDate = DateTime.Now;
        CurrentSaveState.AmountOfAlies = roll ? 10 : 20;
        CurrentSaveState.AmountOfGold = roll ? 1000 : 2000;
    }
}
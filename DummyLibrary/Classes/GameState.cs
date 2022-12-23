using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class GameState : IGameState
{
    private readonly SaveState _saveState;

    public GameState(SaveState saveState)
    {
        _saveState = saveState;
    }

    public DateTime GetSaveDate() => _saveState.SaveDate;

    public string GetSaveName() => _saveState.SaveName;
    public SaveState GetState() => _saveState;
}
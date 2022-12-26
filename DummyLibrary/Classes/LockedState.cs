namespace DummyLibrary.Classes;

public class LockedState : PlayerState
{
    public LockedState(AudioPlayer player) : base(player)
    {
    }

    public override void ClickLock()
    {
        PlayerState newState = Player.IsPlaying ? new PlayingState(Player) : new ReadyState(Player);

        Player.ChangeState(newState);
    }
}
namespace DummyLibrary.Classes;

public class PlayingState : PlayerState
{
    public PlayingState(AudioPlayer player) : base(player)
    {
    }

    public override void ClickLock()
    {
        Console.WriteLine("Locking the player...");
        Player.ChangeState(new LockedState(Player));
    }

    public override void ClickPlay()
    {
        Player.StopPlayback();
        Player.ChangeState(new ReadyState(Player));
    }

    public override void ClickNext() => Player.NextSong();

    public override void ClickPrevious() => Player.PreviousSong();
}
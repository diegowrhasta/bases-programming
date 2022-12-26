namespace DummyLibrary.Classes;

public class ReadyState : PlayerState
{
    public ReadyState(AudioPlayer player) : base(player)
    {
    }

    public override void ClickLock() => Player.ChangeState(new LockedState(Player));

    public override void ClickPlay()
    {
        if (string.IsNullOrEmpty(Player.CurrentSong))
        {
            Player.CurrentSong = Player.Playlist.ElementAt(0);
        }

        Player.StartPlayback();
        Player.ChangeState(new PlayingState(Player));
    }

    public override void ClickNext()
    {
        if (string.IsNullOrEmpty(Player.CurrentSong))
        {
            Player.CurrentSong = Player.Playlist.ElementAt(0);
        }

        Player.NextSong();
    }

    public override void ClickPrevious()
    {
        if (string.IsNullOrEmpty(Player.CurrentSong))
        {
            Player.CurrentSong = Player.Playlist.ElementAt(0);
        }

        Player.PreviousSong();
    }
}
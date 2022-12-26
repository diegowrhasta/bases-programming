namespace DummyLibrary.Classes;

public class AudioPlayer
{
    private PlayerState? _state;

    public int Volume { get; set; }

    public IList<string> Playlist { get; set; } = new List<string>
    {
        "Take me to Church",
        "Help herself",
        "Cowboy Tears",
        "Lost in Hollywood"
    };

    public string CurrentSong { get; set; } = string.Empty;
    public int ElapsedSeconds { get; set; }
    public bool IsPlaying { get; set; }

    public void ChangeState(PlayerState state) => _state = state;

    // Access to state functions
    public void ClickLock() => _state!.ClickLock();
    public void ClickPlay() => _state!.ClickPlay();
    public void ClickNext() => _state!.ClickNext();
    public void ClickPrevious() => _state!.ClickPrevious();

    // Player own functions (state may call them)
    public void StartPlayback()
    {
        Console.WriteLine($"Playing a song... {CurrentSong}");
        Console.WriteLine("It's beautiful!");
        IsPlaying = true;
    }

    public void StopPlayback()
    {
        Console.WriteLine($"Stopping song... {CurrentSong}");
        Console.WriteLine("Silence now");
        IsPlaying = false;
    }

    public void NextSong()
    {
        var currentSongIndex = Playlist.IndexOf(CurrentSong);
        var nextSongIndex = currentSongIndex + 1;
        nextSongIndex = nextSongIndex >= Playlist.Count ? Playlist.Count - 1 : nextSongIndex;

        var newCurrentSong = Playlist.ElementAt(nextSongIndex);
        CurrentSong = newCurrentSong;
        ElapsedSeconds = 0;
        Console.WriteLine($"Changing current song for next one... {CurrentSong}");
        if (IsPlaying)
        {
            Console.WriteLine("Playing...");
        }
    }

    public void PreviousSong()
    {
        var currentSongIndex = Playlist.IndexOf(CurrentSong);
        var nextSongIndex = currentSongIndex - 1;
        nextSongIndex = nextSongIndex <= 0 ? 0 : nextSongIndex;

        var newCurrentSong = Playlist.ElementAt(nextSongIndex);
        CurrentSong = newCurrentSong;
        ElapsedSeconds = 0;
        Console.WriteLine($"Changing current song for previous one... {CurrentSong}");
        if (IsPlaying)
        {
            Console.WriteLine("Playing...");
        }
    }

    public void FastForward(int secondsForward) => ElapsedSeconds += secondsForward;
    public void Rewind() => ElapsedSeconds -= 5;
}
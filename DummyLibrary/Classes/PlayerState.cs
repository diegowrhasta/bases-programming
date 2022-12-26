namespace DummyLibrary.Classes;

public abstract class PlayerState
{
    protected readonly AudioPlayer Player;

    protected PlayerState(AudioPlayer player)
    {
        Player = player;
    }

    public virtual void ClickLock()
    {
        // Do nothing
    }

    public virtual void ClickPlay()
    {
        // Do nothing
    }

    public virtual void ClickNext()
    {
        // Do nothing
    }

    public virtual void ClickPrevious()
    {
        // Do nothing
    }
}
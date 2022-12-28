namespace DummyLibrary.Classes;

public class WashingMachine
{
    private int _numberOfClothes;

    public void WashClothes()
    {
        UpdateClothes();
        // Do more washing logic here.
    }
    
    private void UpdateClothes()
    {
        _numberOfClothes++;
    }
}
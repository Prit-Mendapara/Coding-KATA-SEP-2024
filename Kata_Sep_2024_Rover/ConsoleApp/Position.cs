namespace ConsoleApp1;

public class Position
{
    public Position(int x = 0, int y = 0)
    {
        X = x;
        Y = y;
    }
    public int X { get; private set; }
    
    public int Y { get; private set; }

    public void IncreaseX()
    {
        X++;
    }

    public void IncreaseY()
    {
        Y++;
    }
}
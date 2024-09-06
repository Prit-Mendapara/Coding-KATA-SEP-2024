namespace ConsoleApp1;

public class Navigator
{
    public Navigator(Position position)
    {
        Position = position;
    }
    public bool IsValidKey(string key) =>
        key == "Forward" || key == "Left" || key == "Right";

    public void MoveForward()
    {
        Position.IncreaseY();
    }

    public Position Position { get; }
}
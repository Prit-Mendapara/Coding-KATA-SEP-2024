namespace ConsoleApp1;

public class Navigator
{
    public Navigator(Position? position = null)
    {
        Position = position ?? new Position();
    }
    public bool IsValidKey(string key) =>
        key == "Forward" || key == "Left" || key == "Right";

    public void MoveForward()
    {
        //Position.Y++;
    }

    public Position Position { get; }
}
namespace ConsoleApp1;

public class Navigator
{
    public bool IsValidKey(string key) =>
        key == "Forward" || key == "Left" || key == "Right";
}
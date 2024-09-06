using ConsoleApp1;

namespace ConsoleApp.UnitTest;

[TestFixture]
public class NavigatorTest
{
    private readonly Navigator _navigator = new();
    
    [TestCase("Forward")]
    [TestCase("Left")]
    [TestCase("Right")]
    public void Detect_Valid_Key(string key)
    {
        var isValid = _navigator.IsValidKey(key);

        // Assert
        Assert.That(isValid, Is.True);
    }
}
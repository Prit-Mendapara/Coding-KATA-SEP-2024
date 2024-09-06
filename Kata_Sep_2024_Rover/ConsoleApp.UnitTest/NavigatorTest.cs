using ConsoleApp1;

namespace ConsoleApp.UnitTest;

[TestFixture]
public class NavigatorTest
{
    [TestCase("Forward")]
    [TestCase("Left")]
    [TestCase("Right")]
    public void Detect_Valid_Key(string key)
    {
        // Arrange
        var navigator = new Navigator();
        
        // Act
        var isValid = navigator.IsValidKey(key);

        // Assert
        Assert.That(isValid, Is.True);
    }
}
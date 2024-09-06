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

    [Test]
    public void Move_Forward()
    {
        //Arrange
        var navigator = new Navigator();
        
        //Act
        navigator.MoveForward();

        //Assert
        Assert.That(navigator.Position.X, Is.Zero);
        Assert.That(navigator.Position.Y, Is.EqualTo(1));
    }
}
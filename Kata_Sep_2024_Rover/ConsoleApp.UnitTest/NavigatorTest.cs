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
        var navigator = new Navigator(new Position());
        
        // Act
        var isValid = navigator.IsValidKey(key);

        // Assert
        Assert.That(isValid, Is.True);
    }

    [Test]
    public void Move_Forward_With_Initial_Position()
    {
        //Arrange
        var navigator = new Navigator(new Position());
        
        //Act
        navigator.MoveForward();

        //Assert
        Assert.That(navigator.Position.X, Is.Zero);
        Assert.That(navigator.Position.Y, Is.EqualTo(1));
    }

    [TestCase(3, 4)]
    [TestCase(4, 2)]
    public void Set_Position(int xPos, int yPos)
    {
        //Act
        var navigator = new Navigator(new Position(xPos, yPos));

        //Assert
        Assert.That(navigator.Position.X, Is.EqualTo(xPos));
        Assert.That(navigator.Position.Y, Is.EqualTo(yPos));
    }
}
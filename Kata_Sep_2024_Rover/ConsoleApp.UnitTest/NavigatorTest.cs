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
    public void Move_Forward_With_Initial_Position()
    {
        //Arrange
        var navigator = new Navigator();
        
        //Act
        navigator.MoveForward();

        //Assert
        Assert.That(navigator.Position.X, Is.Zero);
        Assert.That(navigator.Position.Y, Is.EqualTo(1));
    }

    [Test]
    public void Set_Position()
    {
        //Arrange
        
        //Act
        
        //Assert
    }

    [Test]
    public void Move_Forwad()
    {
        //Arrange
        var x = 1;
        var y = 1;

        var navigator = new Navigator();

        //Act

        navigator.MoveForward();
        
        //Assert
        
        Assert.That(navigator.Position.X, Is.EqualTo(1));
        Assert.That(navigator.Position.Y, Is.EqualTo(2));
    }
}
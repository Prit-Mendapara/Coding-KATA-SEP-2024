using ConsoleApp1;

namespace ConsoleApp.UnitTest;

[TestFixture]
public class PositionTest
{
    [Test]
    public void Validate_Initial_Position()
    {
        //Act
        var position = new Position();

        //Assert
        Assert.That(position.X, Is.Zero);
        Assert.That(position.Y, Is.Zero);
    }

    [Test]
    [TestCase(0, 1)]
    [TestCase(3, 4)]
    public void Increase_X_Position(int currentPosition, int expectedPosition)
    {
        //Arrange
        var position = new Position(x: currentPosition);
        
        //Act
        position.IncreaseX();
        
        //Assert
        Assert.That(position.X,Is.EqualTo(expectedPosition));
    }
    
    [Test]
    [TestCase(0, 1)]
    [TestCase(3, 4)]
    public void Increase_Y_Position(int currentPosition, int expectedPosition)
    {
        //Arrange
        var position = new Position(y: currentPosition);
        
        //Act
        position.IncreaseY();
        
        //Assert
        Assert.That(position.Y,Is.EqualTo(expectedPosition));
    }

    [Test]
    public void Increase_Position()
    {
        //Arrange
        var position = new Position(x: 2, y: 4);
        
        //Act
        position.IncreaseX();
        position.IncreaseY();
        
        //Assert
        Assert.That(position.X, Is.EqualTo(3));
        Assert.That(position.Y, Is.EqualTo(5));
    }
}
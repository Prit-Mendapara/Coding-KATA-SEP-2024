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
}
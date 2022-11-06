namespace GeometricAreaCalculator.Tests;

public class CircleTests
{
    [TestCase(-1)]
    public void CreateNotValidCircle_ShouldThrow(double radius)
    {
        // Act
        var action = () => new Circle(radius);

        // Assert
        action.ShouldThrow<Exception>();
    }
    
    [TestCase(4)]
    public void CalculateArea_ReturnCorrectValue(double radius)
    {
        // Arrange 
        var circle = new Circle(radius);
        
        // Act
        var area = circle.CalculateArea();

        // Assert
        area.ShouldBeOfType<double>().ShouldBe(16*Math.PI);
    }
}
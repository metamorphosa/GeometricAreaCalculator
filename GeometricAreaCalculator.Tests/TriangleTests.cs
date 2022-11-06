namespace GeometricAreaCalculator.Tests;

public class TriangleTests
{
    [TestCase(-1, 0, 2)]
    [TestCase(0, 0, 0)]
    [TestCase(1, 1, 20)]
    public void CreateNotValidTriangle_ShouldThrow(double a, double b, double c)
    {
        // Act
        var action = () => new Triangle(a, b, c);

        // Assert
        action.ShouldThrow<Exception>();
    }
    
    [TestCase(3,4,5)]
    public void CheckIsRectangular_ShouldBeTrue(double a, double b, double c)
    {
        // Act
        var triangle = new Triangle(a, b, c);

        // Assert
        triangle.IsRectangular.ShouldBeTrue();
    }
    
    [TestCase(3,4,5)]
    public void CalculateArea_ReturnCorrectValue(double a, double b, double c)
    {
        // Arrange
        var triangle = new Triangle(a, b, c);
        
        // Act
        var area = triangle.CalculateArea();

        // Assert
        area.ShouldBeOfType<double>().ShouldBe(6);
    }
}
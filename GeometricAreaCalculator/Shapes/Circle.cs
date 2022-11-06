using GeometricAreaCalculator.Exceptions;
using GeometricAreaCalculator.MathUtils;

namespace GeometricAreaCalculator.Shapes;

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Validators.Arg(radius).NotNegative();
        
        Radius = radius;
    }
    
    public override double CalculateArea()
    {
        return AreaUtils.GetCircleArea(Radius);
    }
}
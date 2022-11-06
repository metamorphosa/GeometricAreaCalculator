using GeometricAreaCalculator.Exceptions;
using GeometricAreaCalculator.MathUtils;

namespace GeometricAreaCalculator.Shapes;

public class Triangle : Shape
{
    private double A { get; set; }
    private double B { get; set; }
    private double C { get; set; }
    public bool IsRectangular { get; set; }
    
    public Triangle(double a, double b, double c)
    {
        Validators.Arg(a).NotNegative();
        Validators.Arg(b).NotNegative();
        Validators.Arg(c).NotNegative();

        ThrowIfTriangleNotValid(a, b, c);
        
        A = a;
        B = b;
        C = c;

        SetIsRectangular();
    }

    public override double CalculateArea()
    {
        return AreaUtils.GetHeronsFormulaTriangleArea(A, B, C);
    }

    private void SetIsRectangular()
    {
        var sides = new[] { A, B, C }.OrderBy(e => e).ToArray();

        var hypotenuse = sides[2];
        var firstCathetus = sides[0];
        var secondCathetus = sides[1];
        var squaredHypotenuse = hypotenuse * hypotenuse;
        var squaredCathetusesSum = firstCathetus * firstCathetus + secondCathetus * secondCathetus;

        IsRectangular = Math.Abs(squaredCathetusesSum - squaredHypotenuse) < double.Epsilon;
    }

    private void ThrowIfTriangleNotValid(double a, double b, double c)
    {
        if (a + b > c && b + c > a && a + c > b)
        {
            return;
        }

        throw new Exception("Triangle is not valid");
    }
}
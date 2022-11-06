namespace GeometricAreaCalculator.MathUtils;

public static class AreaUtils
{
    public static double GetHeronsFormulaTriangleArea(double a, double b, double c)
    {
        var p = (a + b + c) / 2;
        var expression = p * (p - a) * (p - b) * (p - c);
        return Math.Sqrt(expression);
    }

    public static double GetCircleArea(double radius)
    {
        return radius * radius * Math.PI;
    }
}
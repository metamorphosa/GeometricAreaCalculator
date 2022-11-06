namespace GeometricAreaCalculator.Exceptions;

public static class ArgumentExtensions
{ 
    public static Validators.Argument<double> GreaterThan(this Validators.Argument<double> arg, int minValue, string? message)
    {
        var exception = message ?? $"{arg.ParamName} should be greater than {minValue}";
        return arg.Validate(arg.Value > minValue, exception);
    }
    
    public static Validators.Argument<double> NotNegative(this Validators.Argument<double> arg)
    {
        return GreaterThan(arg, 0, $"{arg.ParamName} is negative");
    }
    
    private static Validators.Argument<T> Validate<T>(this Validators.Argument<T> arg, bool condition, string message)
    {
        if (condition)
        {
            return arg;
        }
        
        throw new Exception(message);
    }
}
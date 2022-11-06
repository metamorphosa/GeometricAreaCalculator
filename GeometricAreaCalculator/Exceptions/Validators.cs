using System.Runtime.CompilerServices;

namespace GeometricAreaCalculator.Exceptions;

public static class Validators
{
    public static Argument<T> Arg<T>(T value, [CallerArgumentExpression("value")] string param = "")
    {
        return new Argument<T>(value, param);
    }
    
    public class Argument<T>
    {
        public T Value { get; private set; }
        public string ParamName { get; private set; }

        public Argument(T value, string param)
        {
            Value = value;
            ParamName = param;
        }
    }
}
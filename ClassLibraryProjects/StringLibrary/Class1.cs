namespace UtilityLibraries;

public class CalLibrary
{
    public decimal Add(decimal x, decimal y)
    {
        decimal sum = x + y;
        return sum;
    }

    public decimal Subtract(decimal x, decimal y)
    {
        decimal sub = x - y;
        return sub;
    }

    public decimal Multiply(decimal x, decimal y)
    {
        decimal multiply = x * y;
        return RoundTo3DecimalPlaces(multiply);
    }

    public decimal Divide(decimal x, decimal y)
    {
        if (y == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        decimal divisor = x / y;
        return RoundTo3DecimalPlaces(divisor);
    }

    public decimal Modulo(decimal x, decimal y)
    {
        if (y == 0)
        {
            throw new DivideByZeroException("Cannot perform modulo by zero.");
        }

        decimal reminder = x % y;
        return reminder;
    }

    // Helper method to round to 3 decimal places
    private decimal RoundTo3DecimalPlaces(decimal value)
    {
        return decimal.Round(value, 3);
    }
}

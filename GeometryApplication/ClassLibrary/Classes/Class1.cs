namespace ClassLibrary.Classes;

public interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}
public class Square : IShape
{
    public static double CalculateArea(length)
    {
        return length*length;
    }
    public static double CalculatePerimeter()
    {
        return 4*length
    }
}
public class Rectangle : IShape
{
    public static double CalculateArea(length, width)
    {
        return length*width;
    }
    public static double CalculatePerimeter(length, width)
    {
        return 2*(length+width)
    }
}

public class Rectangle : IShape
{
    public static double CalculateArea(width, height)
    {
        return (width*height)/2;
    }
    public static double CalculatePerimeter(length, width)
    {
        return 2*(length+width)
    }
}

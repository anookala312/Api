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
        double area = length*length;
        return area;
    }
    public static double CalculatePerimeter()
    {
        double perimeter = 4*length
        return perimeter;
    }
}
public class Rectangle : IShape
{
    public static double CalculateArea(length, width)
    {
        double area = length*width;
        return area;
    }
    public static double CalculatePerimeter(length, width)
    {
        double perimeter = 2*(length+width)
        return perimeter;
    }

}

public class Triangle : IShape
{
    public static double CalculateArea(side1, side2, side3)
    {
        double area = (width*height)/2;
        return area;
    }
    public static double CalculatePerimeter(length, width)
    {
        double perimeter = (length+width+Math.Sqrt((Math.Pow(length,2))+((Math.Pow(width,2)))))
        return perimeter;
    }
}

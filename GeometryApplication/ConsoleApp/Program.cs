using System.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
using ClassLibrary.Classes;
var featureManagement = new Dictionary<string, string> {{ "FeatureManagement:Square", "true"}, { "FeatureManagement:Rectangle", "false"}, { "FeatureManagement:Triangle", "true"}};

IConfigurationRoot configuration = new ConfigurationBuilder().AddInMemoryCollection(featureManagement).Build();

IServiceCollection services = new ServiceCollection();
services.AddFeatureManagement(configuration);
IServiceProvider serviceProvider = services.BuildServiceProvider();

IFeatureManager featureManager = serviceProvider.GetRequiredService<IFeatureManager>();
Console.WriteLine("Choose Shape:");
Console.WriteLine("1. Square");
Console.WriteLine("2. Rectangle");
Console.WriteLine("3. Right angle Triangle");
var num = Console.ReadLine();
switch (num)
{
    case "1":
        if (await featureManager.IsEnabledAsync("Square"))
        {
            Console.WriteLine("What is the Length:");
            if (int.TryParse(Console.ReadLine(), out int length) && length > 0)
            {
                var square = new Square(length);
                Console.WriteLine($"The Area if the Square is: {square.CalculateArea()}");
                Console.WriteLine($"The Perimeter of the Square id: {square.CalculatePerimeter()}");
            }
            else
            {
                Console.WriteLine("Invalid input for length.");
            }

        }
        else
        {
            Console.WriteLine("Not Accessible");
        }
        break;
     case "2":
        if (await featureManager.IsEnabledAsync("Rectangle"))
        {
            Console.WriteLine("What is the Length:");
            if (int.TryParse(Console.ReadLine(), out int length) && length > 0)
            {
                Console.WriteLine("What is the Width:");
                if (int.TryParse(Console.ReadLine(), out int width) && width > 0)
                {
                    var rectangle = new Rectangle(length, width);
                    Console.WriteLine($"The Area if the Rectangle is: {rectangle.CalculateArea()}");
                    Console.WriteLine($"The Perimeter of the Rectangle is: {rectangle.CalculatePerimeter()}");
                }
                else
                {
                    Console.WriteLine("Invalid input for width.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for length.");
            }

        }
        else
        {
            Console.WriteLine("Not Accessible");
        }
        break;
    case "3":
        if (await featureManager.IsEnabledAsync("Triangle"))
        {
            Console.WriteLine("What is the Length of Side1:");
            if (int.TryParse(Console.ReadLine(), out int side1) && side1 > 0)
            {
                Console.WriteLine("What is the Length of Side2");
                if (int.TryParse(Console.ReadLine(), out int side2) && side2 > 0)
                {
                    Console.WriteLine("What is the Length of Side3:");
                    if (int.TryParse(Console.ReadLine(), out int side3) && side3 > 0)
                    {
                        var triangle = new Triangle(side1,side2,side3);
                        Console.WriteLine($"The Area of the Triangle is: {triangle.CalculateArea()}");
                        Console.WriteLine($"The Perimeter of the Triangle is: {triangle.CalculatePerimeter()}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for side3.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for side2.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for side1.");
            }
        }
        else
        {
            Console.WriteLine("Not Accessible");
        }
        break;
    default:
        Console.WriteLine("Select a Number from 1 to 3");
        break;
}

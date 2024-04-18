using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ClassLibrary.Classes;

var featureManagement = new Dictionary<string, string> {
    { "FeatureManagement:Square", "true" },
    { "FeatureManagement:Rectangle", "false" },
    { "FeatureManagement:Triangle", "true" }
};

IConfigurationRoot configuration = new ConfigurationBuilder()
    .AddInMemoryCollection(featureManagement)
    .Build();

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
            int length = int.Parse(Console.ReadLine()); // Convert string to int
            Console.WriteLine($"The Area if the Square is: {Square.CalculateArea(length)}");
            Console.WriteLine($"The Perimeter of the Square id: {Square.CalculatePerimeter(length)}");
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
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the Width:");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine($"The Area if the Rectangle is: {Rectangle.CalculateArea(length, width)}"); 
            Console.WriteLine($"The Perimeter of the Rectangle is: {Rectangle.CalculatePerimeter(length, width)}");
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
            int side1 = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the Length of Side2");
            int side2 = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the Length of Side3:");
            int side3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The Area of the Triangle is: {Triangle.CalculateArea(side1, side2, side3)}");
            Console.WriteLine($"The Perimeter of the Triangle is: {Triangle.CalculatePerimeter(side1, side2, side3)}");
        }
        else
        {
            Console.WriteLine("Not Accessible");
        }
        break;
}

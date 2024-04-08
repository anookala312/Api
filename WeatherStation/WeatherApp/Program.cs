using WeatherStation.ClassLibrary.Interfaces;
using System;

namespace WeatherStation.ClassLibrary/// <summary>
                                     /// Represents the main program.
                                     /// </summary>
class Program
{
    /// <summary>
    /// The entry point of the program.
    /// </summary>
    /// <param name="args">The command-line arguments.</param>
    static void Main(string[] args)
    {
        WeatherData<int> data = WeatherData<int>.Instance;

        // Create display objects using the factory
        IDisplay<int> obs1 = DisplayFactory.CreateDisplay(DisplayType.CurrentConditions);
        IDisplay<int> obs2 = DisplayFactory.CreateDisplay(DisplayType.Statistics);
        IDisplay<int> obs3 = DisplayFactory.CreateDisplay(DisplayType.Forecast);

        // Subscribe display objects to the WeatherData
        data.Subscribe(obs1);
        data.Subscribe(obs2);
        data.Subscribe(obs3);

        var random = new Random();
        data.Value = random.Next(-15, 16);

        Console.ReadLine();
    }
}

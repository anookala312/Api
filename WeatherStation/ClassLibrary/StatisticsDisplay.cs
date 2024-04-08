namespace WeatherStation.ClassLibrary;

using WeatherStation.ClassLibrary.Interfaces;

/// <summary>
/// A class representing a display for weather statistics.
/// </summary>
public class StatisticsDisplay : IDisplay<int>
{
    /// <summary>
    /// Displays the weather statistics based on the provided temperature.
    /// </summary>
    /// <param name="param">The temperature used for displaying statistics.</param>
    public void Display(int param)
    {
        Console.WriteLine($"Today's Max temp is {param + 10}°C and Min temp is {param - 10}°C");
    }
}
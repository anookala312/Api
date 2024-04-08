namespace WeatherStation.ClassLibrary;

using WeatherStation.ClassLibrary.Interfaces;

/// <summary>
/// A class representing a display for weather forecasts.
/// </summary>
public class ForecastDisplay : IDisplay<int>
{
    /// <summary>
    /// Displays the forecast based on the provided temperature.
    /// </summary>
    /// <param name="param">The temperature used for forecasting.</param>
    public void Display(int param)
    {
        if (param <= 0)
        {
            Console.WriteLine($"Today the climate would be cold, with a high likelihood of snow");
        }
        else if (param > 0 && param < 10)
        {
            Console.WriteLine($"Today the climate would be a bit cold, with a chance of snow");
        }
        Console.WriteLine($"Today the climate is warm, enjoy the sun");
    }
}
using WeatherStation.ClassLibrary.Interfaces;
using System;

namespace WeatherStation.ClassLibrary
/// <summary>
/// Represents a factory for creating display objects.
/// </summary>
public class DisplayFactory
{
    /// <summary>
    /// Creates a display object based on the provided display type.
    /// </summary>
    /// <param name="type">The type of display to create.</param>
    /// <returns>A display object of the specified type.</returns>
    public static IDisplay<int> CreateDisplay(DisplayType type)
    {
        switch (type)
        {
            case DisplayType.CurrentConditions:
                return new CurrentConditionsDisplay();
            case DisplayType.Forecast:
                return new ForecastDisplay();
            case DisplayType.Statistics:
                return new StatisticsDisplay();
            default:
                throw new ArgumentException("Invalid display type");
        }
    }
}

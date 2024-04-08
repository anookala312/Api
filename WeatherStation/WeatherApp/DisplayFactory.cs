using WeatherStation.ClassLibrary.Interfaces;
using System;

namespace WeatherStation.ClassLibrary
{
    public enum DisplayType
    {
        CurrentConditions,
        Forecast,
        Statistics
    }

    public class DisplayFactory
    {
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
}

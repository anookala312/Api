namespace WeatherStation.ClassLibrary;

using WeatherStation.ClassLibrary.Interfaces;

/// <summary>
/// A class representing a display for current weather conditions.
/// </summary>
public class CurrentConditionsDisplay : IDisplay<int>
{
    /// <summary>
    /// Displays the current temperature.
    /// </summary>
    /// <param name="param">The current temperature.</param>
    public void Display(int param)
    {
        var temperatureString = param.ToString() + "°C";
        var formattedMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm}: Today's temp outside is {temperatureString}";
        Console.WriteLine(formattedMessage);
    }

    /// <summary>
    /// Displays a custom message.
    /// </summary>
    /// <param name="message">The message to be displayed.</param>
    public void Display(string message)
    {
        Console.WriteLine(message);
    }
}
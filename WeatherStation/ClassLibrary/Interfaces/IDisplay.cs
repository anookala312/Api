namespace WeatherStation.ClassLibrary.Interfaces;

/// <summary>
/// Interface for displaying weather data.
/// </summary>
/// <typeparam name="T">The type of data to be displayed.</typeparam>
public interface IDisplay<T>
{
    /// <summary>
    /// Displays the provided data.
    /// </summary>
    /// <param name="param">The data to be displayed.</param>
    void Display(T param);
}
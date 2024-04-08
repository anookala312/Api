using System.Collections.Generic;
using WeatherStation.ClassLibrary.Interfaces;

namespace WeatherStation.ClassLibrary
/// <summary>
/// A class representing weather data.
/// </summary>
/// <typeparam name="T">The type of weather data.</typeparam>
public class WeatherData<T>
{
    private static WeatherData<T>? instance;
    private IList<IDisplay<T>> subscribers = new List<IDisplay<T>>();

    private WeatherData() { }

    /// <summary>
    /// Gets the singleton instance of WeatherData.
    /// </summary>
    public static WeatherData<T> Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new WeatherData<T>();
            }
            return instance;
        }
    }

    private T? _value;

    /// <summary>
    /// Gets or sets the weather data value.
    /// </summary>
    public T? Value
    {
        get { return _value; }
        set
        {
            _value = value;
            Notify(_value);
        }
    }

    /// <summary>
    /// Subscribes a display object to receive weather updates.
    /// </summary>
    /// <param name="subscriber">The display object to subscribe.</param>
    public void Subscribe(IDisplay<T> subscriber)
    {
        if (!subscribers.Contains(subscriber))
        {
            subscribers.Add(subscriber);
        }
    }

    /// <summary>
    /// Unsubscribes a display object from receiving weather updates.
    /// </summary>
    /// <param name="subscriber">The display object to unsubscribe.</param>
    public void UnSubscribe(IDisplay<T> subscriber)
    {
        if (subscribers.Contains(subscriber))
        {
            subscribers.Remove(subscriber);
        }
    }

    private void Notify(T? message)
    {
        foreach (var sub in subscribers)
        {
            sub.Display(message);
        }
    }
}
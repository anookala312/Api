namespace WeatherStation.ClassLibrary;
using WeatherStation.ClassLibrary.Interfaces;

public class WeatherData<T>
{
    IList<IDisplay<T>> subscribers = new List<IDisplay<T>>();

    private T _value;
    public T Value
    {
        get
        {
            return _value
        }
        set
        {
            _value = value;

            Notify(_value);
        }
    }
    public void Subscribe(IDisplay subscriber)
    {
        if (!subscribers.Contains(subscriber))
        {
            subscribers.Add(subscriber);
        }
    }     

    public void UnSubscribe(IDisplay subscriber)
    {
        if (subscribers.Contains(subscriber))
        {
            subscribers.Remove(subscriber);
        }
    }   

    private void Notify(T message)
    {
        foreach( var sub in subscribers)
        {
            sub.Display(message);
        }
    }
}

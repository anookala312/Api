using System.Collections.Generic;
using WeatherStation.ClassLibrary.Interfaces;

namespace WeatherStation.ClassLibrary
{
    public class WeatherData<T>
    {
        private static WeatherData<T>? instance;
        private IList<IDisplay<T>> subscribers = new List<IDisplay<T>>();

        private WeatherData() { }

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
        public T? Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                Notify(_value);
            }
        }

        public void Subscribe(IDisplay<T> subscriber)
        {
            if (!subscribers.Contains(subscriber))
            {
                subscribers.Add(subscriber);
            }
        }

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
}

namespace WeatherStation.ClassLibrary;

using WeatherStation.ClassLibrary.Interfaces;

public class StatisticsDisplay : IDisplay<int>
{
    public void Display(int param)
    {
        Console.WriteLine($"Todays Max temp is {param+10}°C and Min temp is {param-10}°C");
    }
}
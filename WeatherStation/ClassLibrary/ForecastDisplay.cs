namespace WeatherStation.ClassLibrary;

using WeatherStation.ClassLibrary.Interfaces;

public class ForecastDisplay : IDisplay<int>
{
    public void Display(int param)
    {
        if (param <= 0)
        {
            Console.WriteLine($"Today the climate would be cold, with a high likelyhood of snow");
        }
        else if(param >0 && param<10)
        {
            Console.WriteLine($"Today the climate would be a bit cold, with a chance of snow");
        }
        Console.WriteLine($"Today the climate is warm, enjoy the sun");
    }
}
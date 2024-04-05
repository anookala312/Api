namespace WeatherStation.ClassLibrary;

using WeatherStation.ClassLibrary.Interfaces;

public class CurrentConditionsDisplay : IDisplay<string>
{
    public void Display(string param)
    {
        Console.WriteLine($(param+ "is the max Temp" ));
    }
}
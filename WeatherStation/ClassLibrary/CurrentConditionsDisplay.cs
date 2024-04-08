namespace WeatherStation.ClassLibrary;

using WeatherStation.ClassLibrary.Interfaces;


public class CurrentConditionsDisplay : IDisplay<int>
{
    public void Display(int param) 
    {
        var temperatureString = param.ToString() + "°C";
        var formattedMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm}: Today's temp outside is {temperatureString}";
        Console.WriteLine(formattedMessage); 
    }

    public void Display(string message) 
    {
        Console.WriteLine(message);
    }
}

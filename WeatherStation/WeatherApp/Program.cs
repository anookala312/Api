namespace WeatherStation.WeatherApp;
using WeatherStation.ClassLibrary;

var weatherdata = new WeatherData<string>();
var obs1 = new CurrentConditionalDisplay();

weatherdata.WeatherData(obs1);

weatherdata.Value = Console.ReadLine() ?? "";

Console.ReadLine();

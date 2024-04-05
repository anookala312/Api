using WeatherStation.ClassLibrary;

var data = new WeatherData<string>();
var obs1 = new CurrentConditionsDisplay();

data.Subscribe(obs1);


data.Value = Console.ReadLine() ?? "";

Console.ReadLine();
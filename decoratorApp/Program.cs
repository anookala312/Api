using decoratorApp;

ConcreteComponent component = new ConcreteComponent();

Console.WriteLine(component.GetText());
Console.WriteLine(new PlainDecorator(component).GetText());
Console.WriteLine(new UpperCaseDecorator(component).GetText());
Console.WriteLine(new ColorDecorator(component).GetText());



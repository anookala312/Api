namespace decoratorApp;
class ColorDecorator : Decorator<string>
{
    public ColorDecorator(IComponent<string> component) : base(component)
    {
    }

    public override string GetText()
    {
        string text = $"\u001b[31m{base.GetText()}\u001b[0m";
        return text;
    }
}
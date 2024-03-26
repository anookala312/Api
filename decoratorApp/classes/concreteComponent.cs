namespace decoratorApp;
public class ConcreteComponent : IComponent<string>
{
 public string GetText()
    {
        return "Apples.";
    }
}
namespace DesignPatterns.Observer.interfaces;

public interface IObserver<T>
{
    void Update(T param);
}

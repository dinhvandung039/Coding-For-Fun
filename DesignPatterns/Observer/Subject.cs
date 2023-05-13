namespace Observer;

public class Subject
{
    private readonly List<Observer> _observers = new();

    public void AttachObserver(Observer observer)
    {
        _observers.Add(observer);
    }

    public void DetachObserver(Observer observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers(object arg)
    {
        _observers.ForEach(t => t.Notify(arg));
    }
}

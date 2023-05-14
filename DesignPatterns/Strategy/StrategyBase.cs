namespace Strategy;

public abstract class Strategy
{
    private Strategy _next;

    public Strategy Append(Strategy next)
    {
        if (_next == null)
        {
            _next = next;
        }
        else
        {
            _next.Append(next);
        }

        return this;
    }

    public abstract void Do(int n);
    protected void Next(int n) => _next?.Do(n);
}

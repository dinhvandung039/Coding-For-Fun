public abstract class Process
{
    public void Start()
    {
        FactoryMethod();
        // do something with word
    }

    protected abstract void FactoryMethod();
}
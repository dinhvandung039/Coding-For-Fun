using ChainOfResponsibility;

public class IDE : IKeyHandler
{
    private IKeyHandler _keyHandler;

    public IDE(IKeyHandler keyHandler)
    {
        _keyHandler = keyHandler;
    }

    public void HandleKey(string key)
    {
        if (key == "Ctrl + F")
        {
            Console.WriteLine("Full Search");
        }
        else if (key == "Alt + F4")
        {
            Console.WriteLine("Close Application");
        }
        else
        {
            _keyHandler?.HandleKey(key);
        };
    }
}
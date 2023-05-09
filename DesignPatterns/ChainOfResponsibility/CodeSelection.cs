using ChainOfResponsibility;

public class CodeSelection : IKeyHandler
{
    private IKeyHandler _keyHandler;

    public CodeSelection(IKeyHandler keyHandler)
    {
        _keyHandler = keyHandler;
    }

    public void HandleKey(string key)
    {
        if (key == "Ctrl + F")
        {
            Console.WriteLine("Selection Search");
        }
        else
        {
            _keyHandler?.HandleKey(key);
        };
    }
}
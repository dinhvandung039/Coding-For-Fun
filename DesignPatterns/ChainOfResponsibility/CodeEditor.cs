using ChainOfResponsibility;

public class CodeEditor : IKeyHandler
{
    private IKeyHandler _keyHandler;

    public CodeEditor(IKeyHandler keyHandler)
    {
        _keyHandler = keyHandler;
    }

    public void HandleKey(string key)
    {
        if (key == "Ctrl + F")
        {
            Console.WriteLine("Local Search");
        }
        else
        {
            _keyHandler?.HandleKey(key);
        };
    }
}
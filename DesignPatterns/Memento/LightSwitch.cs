namespace Memento;

// invoker
public class LightSwitch
{
    private readonly ICommand _command;

    public LightSwitch(ICommand command)
    {
        _command = command;
    }

    public void TogglePower()
    {
        _command.Execute();
    }
}

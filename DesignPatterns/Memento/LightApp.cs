namespace Memento;

public class LightApp
{
    Stack<ICommand> _commands;

    public LightApp()
    {
        _commands = new();
    }

    public void AddCommand(ICommand command)
    {
        command.Execute();
        _commands.Push(command);
    }

    public void UndoCommand()
    {
        if (_commands.Count > 0)
        {
            ICommand lastestCommand = _commands.Pop();
            lastestCommand.Undo();
        }
    }
}

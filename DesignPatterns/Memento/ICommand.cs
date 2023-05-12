namespace Memento;

// abstract command interface
public interface ICommand
{
    void Execute();
    void Undo();
}

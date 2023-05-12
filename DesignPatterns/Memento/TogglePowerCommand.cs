namespace Memento;

// Concrete command
public class TogglePowerCommand : ICommand
{
    // store lightbulb receiver
    private readonly Lightbulb _lightbulb;

    public TogglePowerCommand(Lightbulb lightbulb)
    {
        _lightbulb = lightbulb;
    }

    // execute store logic
    public void Execute()
    {
        _lightbulb.TogglePower();
    }

    public void Undo()
    {
        _lightbulb.TogglePower();
    }
}

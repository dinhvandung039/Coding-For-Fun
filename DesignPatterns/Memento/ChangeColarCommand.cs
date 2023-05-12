namespace Memento;

public class ChangeColarCommand : ICommand
{
    private readonly Lightbulb _lightbulb;
    private int _previousColor;
    private int _randomNumer;
    public ChangeColarCommand(Lightbulb lightbulb)
    {
        _lightbulb = lightbulb;
        _randomNumer = new Random().Next(1, 6);
        _previousColor = _randomNumer;
    }

    public void Execute()
    {
        _lightbulb.SetRandomLightColar(_randomNumer);
    }

    public void Undo()
    {
        _lightbulb.SetLightColor(_previousColor);
    }
}

using Memento;

/// Memento is a design pattern that lets you save and restore the previous state of an object without revealing the details of its implementation
/// Known as: snapshot
/// Complexity: 3
/// Popularity: 1
/// Memento + Command
/// 

//var lightbulb = new Lightbulb();
//ICommand turnOnCommand = new TogglePowerCommand(lightbulb);


//// Client
//var lightSwitch = new LightSwitch(turnOnCommand);
//lightSwitch.TogglePower();

var lightbulb = new Lightbulb();
var _lightApp = new LightApp();
ICommand togglePowerCommand1 = new TogglePowerCommand(lightbulb);
_lightApp.AddCommand(togglePowerCommand1);

ICommand togglePowerCommand2 = new ChangeColarCommand(lightbulb);
_lightApp.AddCommand(togglePowerCommand2);

ICommand togglePowerCommand3 = new ChangeColarCommand(lightbulb);
_lightApp.AddCommand(togglePowerCommand3);

Console.WriteLine("Undo Command");
ICommand togglePowerCommand4 = new ChangeColarCommand(lightbulb);
_lightApp.UndoCommand();

ICommand togglePowerCommand5 = new TogglePowerCommand(lightbulb);
_lightApp.AddCommand(togglePowerCommand4);
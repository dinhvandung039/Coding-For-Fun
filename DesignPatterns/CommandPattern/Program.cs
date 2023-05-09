using CommandPattern;
/// Command is a behavioral pattern that converts requests or simple operation into objects
/// Complexity: 1
/// Popularity: 3
/// 


Invoker invoker = new Invoker();
invoker.SetOnStart(new SimpleCommand("Say Hi!"));

Receiver receiver = new Receiver();
invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

invoker.DoSomethingImportant();
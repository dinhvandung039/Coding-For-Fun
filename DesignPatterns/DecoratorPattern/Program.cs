// Decorator is a structural design pattern that lets you attach new behaviors to objects
// by placing these objects inside special wrapper objects that contain the behaviors.

using Decorator_Wrapper_Pattern;

var ourMilkTea = new Bubble(new BlackSugar(new MilkTea()));

Console.WriteLine(ourMilkTea.Cost().ToString());


// inheritance structure
// composition flexiblility
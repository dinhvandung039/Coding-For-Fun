


using Decorator_Wrapper_Pattern;

var ourMilkTea = new Bubble(new BlackSugar(new MilkTea()));

Console.WriteLine(ourMilkTea.Cost().ToString());
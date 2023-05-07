using FacadePattern;


/// Here we provide a simple Facade to work with more complex underlying logic provided by
/// a complex system involving much more business logic.  The facade provides a simple interface
/// to a complex subsystem. 
/// Complexity: 1
/// Popularity: 2
/// 
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("🛍 Welcome to the Grocery Reporting System");

var reporter = new DailyReporter();

reporter.KickOffProduceReport();
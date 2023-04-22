using FactoryMethod.Creators;
using FactoryMethod.Creators.CreatorsImplementations;
using RealisticDependencies.Implementations;
using RealisticDependencies.Interfaces;

var logger = new ConsoleLogger();

var deliveryQueue = new CloudQueue(logger);

logger.LogInfo("🚚  Welcome to the Food Delivery Service!");
logger.LogInfo("------------------------------------------");
logger.LogInfo("Please enter a delivery type.");


var deliveryType = Console.ReadLine();

if (string.IsNullOrWhiteSpace(deliveryType))
{
    logger.LogInfo("Error reading delivery type.");
}

try
{
    var deliveryCreator = BuildDeliveryCreator(deliveryType, deliveryQueue);
    deliveryCreator.QueueVehicleForDelivery();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

static DeliveryCreator BuildDeliveryCreator(string deliveryType, IAmqpQueue deliveryQueue)
{

    var logger = new ConsoleLogger();

    List<string> validDeliveryOptions = new() { "bicycle", "car" };

    if (!validDeliveryOptions.Contains(deliveryType))
    {
        logger.LogInfo("Please enter a type of delivery [bicycle, car]");
        throw new InvalidOperationException("Cannot set up delivery without valid deliveryType.");
    }

    return deliveryType switch
    {
        "bicycle" => new BicycleDeliveryCreator(deliveryQueue, logger),
        "car" => new CarDeliveryCreator(deliveryQueue, logger),
        _ => throw new InvalidOperationException("Cannot set up delivery without valid Delivery Type."),
    };
}
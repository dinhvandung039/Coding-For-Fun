using FactoryMethod.Creators.CreatorInterfaces;
using FactoryMethod.Models;
using RealisticDependencies.Interfaces;

namespace FactoryMethod.Creators.CreatorsImplementations
{
    public class BicycleDeliveryCreator : DeliveryCreator
    {
        public BicycleDeliveryCreator(IAmqpQueue deliveryQueue, IApplicationLogger logger) : base(deliveryQueue, logger)
        {

        }

        protected override IDeliversFood RegisterVehical()
        {
            var bicycle = new Bicycle
            {
                Color = "blue",
                Style = "Road",
                Make = "Trek",
                Model = "Foo",
            };

            _logger.LogInfo("Registering a Bicycle to deliver food!", ConsoleColor.Cyan);
            return bicycle;
        }
    }
}

using FactoryMethod.Creators.CreatorInterfaces;
using FactoryMethod.Models;
using RealisticDependencies.Interfaces;

namespace FactoryMethod.Creators.CreatorsImplementations
{
    public class CarDeliveryCreator : DeliveryCreator
    {
        public CarDeliveryCreator(IAmqpQueue deliveryQueue, IApplicationLogger logger) : base(deliveryQueue, logger) { }

        protected override IDeliversFood RegisterVehical()
        {
            var car = new Car
            {
                Year = 2010,
                Color = "black",
                Make = "Honda",
                Model = "Civic",
                LicensePlate = "123",
            };
            _logger.LogInfo("Registering a Car to deliver food!", ConsoleColor.Green);
            return car;
        }
    }
}

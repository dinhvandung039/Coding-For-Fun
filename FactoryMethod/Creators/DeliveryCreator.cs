using FactoryMethod.Creators.CreatorInterfaces;
using Newtonsoft.Json;
using RealisticDependencies.Implementations;
using RealisticDependencies.Interfaces;

namespace FactoryMethod.Creators
{
    public abstract class DeliveryCreator
    {
        private readonly IAmqpQueue _deliveryQueue;
        protected readonly IApplicationLogger _logger;

        public DeliveryCreator(IAmqpQueue deliveryQueue, IApplicationLogger logger)
        {
            _deliveryQueue = deliveryQueue;
            _logger = logger;
        }

        protected abstract IDeliversFood RegisterVehical();

        public void QueueVehicleForDelivery()
        {
            var vehicle = RegisterVehical();
            var vehiclePayload = JsonConvert.SerializeObject(vehicle);
            var queueMessage = new QueueMessage(vehiclePayload);
            _deliveryQueue.Add(queueMessage);
            _logger.LogInfo($"Queued up vehicle of type {vehicle.GetType()} for food delivery.");
        }
    }
}

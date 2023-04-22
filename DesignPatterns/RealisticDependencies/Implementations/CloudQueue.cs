using RealisticDependencies.Interfaces;

namespace RealisticDependencies.Implementations
{
    public class CloudQueue : IAmqpQueue
    {
        private readonly IApplicationLogger _logger;

        public CloudQueue(IApplicationLogger logger)
        {
            _logger = logger;
        }

        public void Add(QueueMessage item)
        {
            Thread.Sleep(250);
            _logger.LogInfo($"Added to queue: {item.Content}", ConsoleColor.Magenta);
        }
    }
}

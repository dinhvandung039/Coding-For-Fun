using RealisticDependencies.Implementations;

namespace RealisticDependencies.Interfaces
{
    public interface IAmqpQueue
    {
        void Add(QueueMessage item);
    }
}

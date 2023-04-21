namespace RealisticDependencies.Implementations
{
    public class QueueMessage
    {
        public string Content { get; set; }
        public QueueMessage(string content)
        {
            Content = content;
        }
    }
}

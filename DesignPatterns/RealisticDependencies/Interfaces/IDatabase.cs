namespace RealisticDependencies.Interfaces
{
    public interface IDatabase
    {
        Task Connect(string client);
        Task Disconnect();
        Task<string> ReadData(string id);
        Task WriteData(string key, string data);
        Task<List<string>> DumpData();
    }
}

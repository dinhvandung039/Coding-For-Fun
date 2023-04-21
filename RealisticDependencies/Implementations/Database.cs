using RealisticDependencies.Interfaces;

namespace RealisticDependencies.Implementations
{
    public class Database : IDatabase
    {
        private string _connectionString;
        private readonly IApplicationLogger _logger;
        private readonly Dictionary<string, string> _data = new();
        private bool _isConnected;

        public Database(string connectionString, IApplicationLogger logger)
        {
            _connectionString = connectionString;
            _logger = logger;
        }

        public async Task Connect(string client)
        {
            await Task.Delay(2500);
            _isConnected = true;
            _logger.LogInfo($"{DateTime.UtcNow} - [{client}] Connected to Database.", ConsoleColor.Magenta);
        }

        public async Task Disconnect()
        {
            await Task.Delay(2500);
            _isConnected = false;
            _logger.LogInfo($"{DateTime.UtcNow} - Disconnected from Database.", ConsoleColor.Magenta);
        }

        public async Task<List<string>> DumpData()
        {
            if (!_isConnected)
            {
                throw new NotSupportedException("Cannot read from database without open connection");
            }

            await Task.Delay(2000);

            try
            {
                return _data.Values.Select(v => v).ToList();
            }
            catch (KeyNotFoundException)
            {
                return new();
            }
        }

        public async Task<string> ReadData(string id)
        {
            if (!_isConnected)
            {
                throw new NotSupportedException("Cannot read from database without open connection");
            }

            if (string.IsNullOrWhiteSpace(id)) { return ""; }
            await Task.Delay(500);

            try
            {
                return _data[id];
            }
            catch (KeyNotFoundException)
            {
                return "";
            }
        }

        public async Task WriteData(string key, string data)
        {
            if (!_isConnected)
            {
                throw new NotSupportedException("Cannot write to database without open connection");
            }

            if (string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(data))
                return;

            await Task.Delay(250);
            _data[key] = data;
        }
    }
}

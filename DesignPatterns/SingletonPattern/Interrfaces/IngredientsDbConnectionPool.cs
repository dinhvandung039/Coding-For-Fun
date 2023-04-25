using RealisticDependencies.Implementations;
using RealisticDependencies.Interfaces;

namespace SingletonPattern.Interrfaces
{
    public class IngredientsDbConnectionPool
    {
        private readonly Database _database;
        private readonly IApplicationLogger _logger;
        private int _openConnect = 0;

        private IngredientsDbConnectionPool(Database database, IApplicationLogger logger)
        {
            _database = database;
            _logger = logger;
        }

        private static readonly Lazy<IngredientsDbConnectionPool> _instance = new(() =>
        {
            var logger = new ConsoleLogger();
            var database = new Database("connectionstring", logger);

            return new IngredientsDbConnectionPool(database, logger);
        });

        public static IngredientsDbConnectionPool Instance = _instance.Value;

        public async Task Connect(string client)
        {
            if (_openConnect >= 5)
            {
                _logger.LogError($"Error - Cannot not acquire new connection. Max connections of {_openConnect}");
                return;
            }

            _openConnect++;
            _logger.LogInfo($"Added connection pool from: {client}", ConsoleColor.Blue);
            await _database.Connect(client);
        }

        public async Task Disconnect()
        {
            if (_openConnect <= 0)
            {
                _logger.LogError($"There are no connections");
                return;
            }

            _openConnect--;
            _logger.LogInfo($"Release connection. Now managing ({_openConnect})", ConsoleColor.Blue);
            await _database.Disconnect();
        }
    }
}

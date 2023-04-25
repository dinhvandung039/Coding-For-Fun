using SingletonPattern.Interrfaces;

const string EastClientId = "US-East";
const string WestClientId = "US-West";
const string NorthClientId = "US-North";
const string SouthClientId = "US-South";


Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("🥦  Connecting to ingredients database...");
var eastClient = IngredientsDbConnectionPool.Instance;
var westClient = IngredientsDbConnectionPool.Instance;
var northClient = IngredientsDbConnectionPool.Instance;
var southClient = IngredientsDbConnectionPool.Instance;

// Open and close connections against the ConnectionPool
await eastClient.Connect(EastClientId);
await westClient.Connect(WestClientId);
await northClient.Connect(NorthClientId);
await southClient.Connect(SouthClientId);

await northClient.Disconnect();
await southClient.Connect(SouthClientId);

await northClient.Disconnect();
await northClient.Disconnect();
await northClient.Disconnect();
await northClient.Disconnect();

Console.WriteLine("🥦  Session complete!");
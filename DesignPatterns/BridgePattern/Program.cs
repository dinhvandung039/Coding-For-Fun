// Would try to avoid helper as much as possible => probably doding some kind of valid design pattern

// real world-example
// List is abstract, string, int are implementation
using BridgePattern;

//List<string> strings = new List<string>();
//ICollection<string> names = new List<string>();
//IEnumerable<string> values = new List<string>();

//List<int> numbers = new List<int>();
//ICollection<int> numbers2 = new List<int>();
//IEnumerable<int> numbers3 = new List<int>();

// This example uses the Bridge Pattern to separate high-level abstractions from implementation details.

/// Complexity: 3
/// Popularity: 1
Console.WriteLine("🧑‍🌾  Welcome to the Farmer's Market!");

const string organicGardens = "Organic Gardens";
const string olsenFarm = "Olsen Farm";
const string andersenFarm = "Andersen Farm";
const string pleasantValley = "Pleasant Valley";
const string hillsideRanch = "Hillside Ranch";


var creditCardProcessor = new CreditCardProcessor();
var giftCardProcessor = new GiftCardProcessor();

var booth1 = new VegetableFarmer(creditCardProcessor);
var booth2 = new VegetableFarmer(giftCardProcessor);
var booth3 = new CattleFarmer(creditCardProcessor);
var booth4 = new Florist(creditCardProcessor);
var booth5 = new Florist(giftCardProcessor);

booth1.ProcessCustomerPayment(10.00m, organicGardens);
booth1.ProcessCustomerPayment(12.00m, organicGardens);
booth1.ProcessCustomerPayment(1.50m, organicGardens);

booth2.ProcessCustomerPayment(15.50m, olsenFarm);

booth3.ProcessCustomerPayment(5.00m, andersenFarm);
booth3.ProcessCustomerPayment(5.00m, andersenFarm);
booth3.ProcessCustomerPayment(5.00m, andersenFarm);

booth4.ProcessCustomerPayment(12.00m, pleasantValley);
booth4.ProcessCustomerPayment(11.00m, pleasantValley);

booth5.ProcessCustomerPayment(12.00m, hillsideRanch);
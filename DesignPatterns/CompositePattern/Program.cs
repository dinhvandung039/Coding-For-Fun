using CompositePattern;
using System.Text;

/// The Composite Pattern allows
/// us to treat the tree of products (a carton of cartons and individual products)
/// as a single logical entity for the purposes of calculating the number of servings
/// in the parent carton.
/// 

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("🍵  Welcome to the Tea Cartonizer");

Console.WriteLine("How many cartons of Green Tea would you like to add?");
var greenCartonsQty = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("How many cartons of White Tea would you like to add?");
var whiteCartonsQty = int.Parse(Console.ReadLine() ?? "0");

// - TeaCartoon
// -- GreenTeaCarton
// -- WhiteTeaCarton

// Our Composite: MixAndMatchBundle
var customerBundle = new MixAndMatchBundle();

// Customer Order is represented as a Dictionary of TeaCartons and their quantity.
var customerOrder = new Dictionary<TeaCarton, int> {
                    { new GreenTeaCarton(), greenCartonsQty },
                    { new WhiteTeaCarton(), whiteCartonsQty }
                   };

customerBundle.BuildBundle(customerOrder);

var bundleServings = customerBundle.GetNumberOfServings();

Console.WriteLine($"Your Mix and Match Bundle Contains {bundleServings} servings.");
namespace BridgePattern
{
    // problem statement

    // top level abstraction
    internal abstract class Vehicle { }

    // implementation
    internal class Lada : Vehicle { }
    internal class Volvo : Vehicle { }

    // lower level abstraction
    internal class LCar : Lada { }
    internal class LTruck : Lada { }
    internal class VCar : Volvo { }
    internal class VTruck : Volvo { }


    /// try to rearrange
    /// lower level abstraction
    internal class Car : Vehicle { }
    internal class Truck : Vehicle { }

    // Implementations
    internal class L2Car : Car { }
    internal class L2Truck : Truck { }
    internal class V2Car : Car { }
    internal class V2Truck : Truck { }
}

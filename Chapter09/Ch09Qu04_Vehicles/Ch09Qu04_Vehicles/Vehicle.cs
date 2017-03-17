using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch09Qu04_Vehicles
{
    //无必要进行实例化，故此用abstract
    public abstract class Vehicle { }

    public abstract class Car : Vehicle { }
    public abstract class Train : Vehicle { }

    //接口必须放在前面吗？还是为了理解上方便？
    public interface IPassengerCarrier { }
    public interface IHeavyLoadCarrier { }

    public class Compact : Car,IPassengerCarrier { }
    public class SUV : Car,IPassengerCarrier { }
    public class Pickup : Car,IHeavyLoadCarrier { }

    public class PassengerTrain : Train,IPassengerCarrier { }
    public class FrightTrain : Train,IHeavyLoadCarrier { }
    public class T424DoubleBogey :Train { }
}

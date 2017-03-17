using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch09Qu04_Vehicles;
using static System.Console;

namespace Ch09Qu05_Traffic
{
    class Program
    {
        static void AddPassenger (IPassengerCarrier Vehicle)
        {
            WriteLine(Vehicle.ToString());   
        }
        static void Main(string[] args)
        {
            AddPassenger(new Compact());
            AddPassenger(new SUV());
            //AddPassenger(new Pickup());
            AddPassenger(new PassengerTrain());
            //此函数相当于以下
            //IPassengerCarrier vehiclenn = new SUV();
            //WriteLine(vehiclenn);
            ReadKey();
        }
    }
}

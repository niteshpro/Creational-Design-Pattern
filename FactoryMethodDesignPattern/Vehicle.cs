using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    public class Car : IVehicle
    {
        public void DisplayInfo()
        {
            Console.WriteLine("This is a Car.");
        }
    }

    public class Bike : IVehicle
    {
        public void DisplayInfo()
        {
            Console.WriteLine("This is a Bike.");
        }
    }

    public class Truck : IVehicle
    {
        public void DisplayInfo()
        {
            Console.WriteLine("This is a Truck.");
        }
    }

}

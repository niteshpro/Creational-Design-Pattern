using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    public class VehicleFactory
    {
        public IVehicle GetVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "car":
                    return new Car();
                case "bike":
                    return new Bike();
                case "truck":
                    return new Truck();
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }
    }

}

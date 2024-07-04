
namespace FactoryMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory vehicleFactory = new VehicleFactory();
            //the Factory Method pattern uses inheritance and relies on a subclass to handle the desired object instantiation.

            IVehicle vehicle1 = vehicleFactory.GetVehicle("car");
            vehicle1.DisplayInfo();  // Output: This is a Car.

            IVehicle vehicle2 = vehicleFactory.GetVehicle("bike");
            vehicle2.DisplayInfo();  // Output: This is a Bike.

            IVehicle vehicle3 = vehicleFactory.GetVehicle("truck");
            vehicle3.DisplayInfo();  // Output: This is a Truck.
        }
    }

}
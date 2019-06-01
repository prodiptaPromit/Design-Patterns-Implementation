using System;

namespace Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory vehicle = new VehicleFactory();

            var motorVehicle = vehicle.GetVehicle(1250);
            motorVehicle.Info();
            motorVehicle.Move();

            motorVehicle = vehicle.GetVehicle("Truck");
            motorVehicle.Info();
            motorVehicle.Move();

            motorVehicle = vehicle.GetVehicle(100);
            motorVehicle.Info();
            motorVehicle.Move();

            Console.ReadKey();
        }
    }
}

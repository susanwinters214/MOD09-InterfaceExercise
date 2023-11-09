using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {     
        var myCar = new Car();
        var myTruck = new Truck();
        var vehicleList = new List<IVehicle>() { myCar, myTruck };



            foreach (var vehicle in vehicleList)
            {
                vehicle.Drive();
                vehicle.ChangeGears(true);
                vehicle.Reverse();
            }

        }
    }
}

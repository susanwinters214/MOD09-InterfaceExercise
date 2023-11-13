using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV() { }

        public double EngineSize { get; set; } = 8.0;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "SUV";
        public int SeatCount { get; set; } = 2;
        public string CompanyName { get; set; } = "Frank's Ford Center";
        public string Motto { get; set; } = "Built Ford Tough";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; } = true;

        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} now driving forward!");
            }
            else
            {
                Console.WriteLine($"Truck {GetType().Name} now driving forward!");
            }

        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} now reversing!");
                HasChangedGears= false;
            }
            else
            {
                Console.WriteLine("Cannot reverse until we change gears.");
            }
        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now parked!");
            }
            else
            {
                Console.WriteLine("Cannot reverse until we change gears.");
            }

        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears= isChanged;
        }

        public bool ChangeGears()
        {
            throw new NotImplementedException();
        }


    }
}


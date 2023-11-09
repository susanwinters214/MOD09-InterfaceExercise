﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        { }

        public double EngineSize { get; set; } = 4.6;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Mustang";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Frank's Ford Center";
        public string Motto { get; set; } = "Built Ford Tough";
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward!");
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            { 
            Console.WriteLine($"{GetType().Name} now reversing!");
            HasChangedGears= false;
        }
        else{
        Console.WriteLine("Cannot reverse until we change gears.");
        }
}
        public void Park() 
        {
            if(HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now parked!");
            }
            else
            {
                Console.WriteLine("Cannot reverse until we change gears.");
            }
           
        }
        public void ChangedGears(bool isChanged) { 
        HasChangedGears= isChanged;
        }

        public bool ChangeGears()
        {
            throw new NotImplementedException();
        }

        public bool ChangeGears(bool v)
        {
            throw new NotImplementedException();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {

        }
        public double EngineSize { get; set; } = 4;
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Highlander";
        public int SeatCount { get; set; } = 7;
        public string Logo { get; set; } = "Toyota";
        public string CompanyName { get; set; } = "Toyota";
        public bool HasChangedGears { get; set; }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward...");
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is in park...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Cannot park until gears are changed.");
            }

        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now moving in reverse...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Cannot reverse until gears are changed.");
            }

        }
    }
}

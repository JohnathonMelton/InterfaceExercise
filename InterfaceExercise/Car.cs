using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {

        }

        public double EngineSize { get; set; } = 4;
        public string Make { get; set; } = "Honda";
        public string Model { get; set; } = "Civic";
        public int SeatCount { get; set; } = 5;
        public string Logo { get; set; } = "H";
        public string CompanyName { get; set; } = "Honda";
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
            if(HasChangedGears == true)
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
            if( HasChangedGears == true)
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

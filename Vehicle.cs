using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_app_with_Class_in_focus_Exercise_2
{
    public class Vehicle
    {
        public string? Name;
        public double FuelConsumption; // liters per Swedish mile = 10 km

        public virtual void CalculateEfficiency()
        {
            Console.WriteLine($"The vehicle {Name} would come {100 / FuelConsumption} km on 10 liters of fuel.");
        }
    }
}

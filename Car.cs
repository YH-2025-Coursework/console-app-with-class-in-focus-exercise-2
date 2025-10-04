using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_app_with_Class_in_focus_Exercise_2
{
    public class Car : Vehicle
    {
        public override void CalculateEfficiency()
        {
            Console.WriteLine($"The car {Name} would come {100 / FuelConsumption:0.##} km on 10 liters of fuel.");
        }
    }
}

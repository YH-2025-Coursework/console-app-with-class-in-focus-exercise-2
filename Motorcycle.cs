using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_app_with_Class_in_focus_Exercise_2
{
    public class Motorcycle : Vehicle
    {
        public override void CalculateEfficiency()
        {
            Console.WriteLine($"The motorcycle {Name} would come {100 / FuelConsumption} km on 10 liters of fuel.");
        }

    }
}

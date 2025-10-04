using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_app_with_Class_in_focus_Exercise_2
{
    public class Motorcycle : Vehicle
    {
        public new void CalculateEfficiency()
        {
            base.CalculateEfficiency();
            Console.WriteLine($"This is a motorcycle.\n");
        }

    }
}

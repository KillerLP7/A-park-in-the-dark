using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_park_in_the_dark
{
    public class Vehicle
    {
        public string Type { get; set; }
        public string CurrentNamePlate { get; set; }

        public string GetNameplate(string nameplate)
        {
            return nameplate;
        }
    }

    public class Car : Vehicle
    {
        // Car-specific properties and methods can be added here
    }

    public class Motorbike : Vehicle
    {
        // Motorbike-specific properties and methods can be added here
    }

}

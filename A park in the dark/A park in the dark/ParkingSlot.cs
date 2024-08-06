using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_park_in_the_dark
{
    public class ParkingSlot
    {
        public int ParkingSlotNr { get; set; }
        public int[] ParkingSlots { get; set; }
        public bool ParkingSlotIsFree { get; set; }

        public string GetCurrentNameplate(string currentNamePlate)
        {
            return currentNamePlate;
        }

        public void AssignVehicle(Vehicle vehicle)
        {
            // Logic to assign a vehicle to the parking slot
        }

        public void RemoveVehicle()
        {
            // Logic to remove a vehicle from the parking slot
        }
    }

}

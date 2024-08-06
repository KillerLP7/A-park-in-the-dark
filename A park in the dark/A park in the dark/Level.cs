using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_park_in_the_dark
{
    public class Level
    {
        public int[] Levels { get; set; }
        public int ParkingSlots { get; set; }

        public int GetParkingSlots(int totalParkingSlots)
        {
            return totalParkingSlots;
        }

        public string GetVehicleOnParkingSlot(int currentParkingSlotNr, string vehicleNamePlate)
        {
            // Logic to get the vehicle on a specific parking slot
            return vehicleNamePlate;
        }

        public ParkingSlot FindFreeSlot()
        {
            // Logic to find a free parking slot
            return new ParkingSlot();
        }
    }

}

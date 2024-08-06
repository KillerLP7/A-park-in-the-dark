using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_park_in_the_dark
{
    public class ParkingBuilding
    {
        public string Pos { get; set; }
        public string Building { get; set; }

        public void GetTotalFreeParkingSlots(int[] allLevels)
        {
            // Logic to get the total number of free parking slots
        }

        public void GetVehiclePos(string vehicleType, string vehicleNameplate, int currentParkingSlot, int currentLevel)
        {
            // Logic to get the position of a vehicle
        }

        public string AskForVehiclePosition(string nameplate)
        {
            // Logic to ask for the position of a vehicle
            return "position";
        }

        public void DirectToFreeSpace(string type, string nameplate, bool isEntering)
        {
            // Logic to direct a vehicle to a free space
        }

        public bool AddVehicle(Vehicle vehicle)
        {
            // Logic to add a vehicle to the parking building
            return true;
        }

        public bool RemoveVehicle(string nameplate)
        {
            // Logic to remove a vehicle from the parking building
            return true;
        }
    }

}

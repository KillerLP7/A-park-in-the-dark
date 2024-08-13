using System;
using System.Collections.Generic;

namespace A_park_in_the_dark
{
    public class ParkingBuilding
    {
        public string BuildingName { get; set; }
        public List<Level> Levels { get; set; } = new List<Level>();

        public ParkingBuilding(string buildingName, int totalLevels, int parkingSlotsPerLevel)
        {
            BuildingName = buildingName;

            // Erstellen der Levels
            for (int i = 0; i < totalLevels; i++)
            {
                Levels.Add(new Level(parkingSlotsPerLevel));
            }
        }

        // Methode zum Abrufen eines Levels
        public Level GetLevel(int levelNumber)
        {
            return Levels[levelNumber - 1]; // Level-Nummer ist 1-basiert
        }

        // Weitere Methoden, wie du sie benötigst
        public bool AddVehicle(int levelNumber, Vehicle vehicle)
        {
            var level = GetLevel(levelNumber);
            var freeSlot = level.FindFreeSlot();
            if (freeSlot != null)
            {
                freeSlot.AssignVehicle(vehicle);
                return true;
            }
            return false;
        }

        public bool RemoveVehicle(string nameplate)
        {
            foreach (var level in Levels)
            {
                foreach (var slot in level.ParkingSlots)
                {
                    //if (!slot.ParkingSlotIsFree && slot.GetCurrentNameplate(nameplate) == nameplate)
                    //{
                    //    slot.RemoveVehicle();
                    //    return true;
                    //}
                }
            }
            return false;
        }
    }
}

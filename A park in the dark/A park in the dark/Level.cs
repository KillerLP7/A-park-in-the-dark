using System.Collections.Generic;

namespace A_park_in_the_dark
{
    public class Level
    {
        public List<ParkingSlot> ParkingSlots { get; set; } = new List<ParkingSlot>();

        public Level(int parkingSlotsPerLevel)
        {
            // Erstellen der Parkplätze
            for (int i = 0; i < parkingSlotsPerLevel; i++)
            {
                ParkingSlots.Add(new ParkingSlot { ParkingSlotNr = i + 1, ParkingSlotIsFree = true });
            }
        }

        // Methode, um einen freien Parkplatz zu finden
        public ParkingSlot FindFreeSlot()
        {
            return ParkingSlots.Find(slot => slot.ParkingSlotIsFree);
        }
    }
}

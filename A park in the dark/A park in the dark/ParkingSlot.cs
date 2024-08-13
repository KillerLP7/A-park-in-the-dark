namespace A_park_in_the_dark
{
    public class ParkingSlot
    {
        public int ParkingSlotNr { get; set; }
        public bool ParkingSlotIsFree { get; set; }
        public int SlotState { get; set; } // 0 = free, 1 = occupied, 2 = blocked

        public Vehicle AssignedVehicle { get; private set; }

        public string GetCurrentNameplate()
        {
            return AssignedVehicle?.CurrentNamePlate;
        }

        public void AssignVehicle(Vehicle vehicle)
        {
            AssignedVehicle = vehicle;
            ParkingSlotIsFree = false;
            SlotState = 1; // Setze SlotState auf 'besetzt'
        }

        public void RemoveVehicle()
        {
            AssignedVehicle = null;
            ParkingSlotIsFree = true;
            SlotState = 0; // Setze SlotState auf 'frei'
        }
    }
}

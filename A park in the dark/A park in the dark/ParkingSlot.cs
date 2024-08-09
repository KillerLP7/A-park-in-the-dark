namespace A_park_in_the_dark
{
    public class ParkingSlot
    {
        public int ParkingSlotNr { get; set; }
        public bool ParkingSlotIsFree { get; set; }

        public Vehicle AssignedVehicle { get; private set; }

        public string GetCurrentNameplate(string currentNamePlate)
        {
            return AssignedVehicle?.CurrentNamePlate;
        }

        public void AssignVehicle(Vehicle vehicle)
        {
            AssignedVehicle = vehicle;
            ParkingSlotIsFree = false;
        }

        public void RemoveVehicle()
        {
            AssignedVehicle = null;
            ParkingSlotIsFree = true;
        }
    }
}

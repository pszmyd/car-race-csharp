namespace Codecool.CarRace
{
    /// <summary>
    /// This class is for simulating a full race with different vehicles and print race results ot the standard output.
    /// </summary>
    public class Race
    {
        public Race()
        {
            IsThereABrokenTruck = false;
            BrockenTrucks = 0;
        }
        public bool IsThereABrokenTruck { get; private set; }
        private int BrockenTrucks { get; set; }
        public static void MoveForOneHour ()
        {

        }
        
        public static void SimulateRace () 
        {

        }

        public static void PrintRaceResults ()
        {

        }

        public void BrokenTrucksCounter (int status) 
        {
            BrockenTrucks += status;
            if (BrockenTrucks > 0)
            {
                IsThereABrokenTruck = true;
            }
            else
            {
                IsThereABrokenTruck = false;
            }
        }

    }
}
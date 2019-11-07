

namespace Codecool.CarRace
{
    /// <summary>
    /// This class is for simulating a full race with different vehicles and print race results ot the standard output.
    /// </summary>
    public class Race
    {
<<<<<<< HEAD

        public int Velocity;

        public static int MoveForOneHour (int distance, int velocity)
=======
        public Race()
        {
            IsThereABrokenTruck = false;
            BrockenTrucks = 0;
        }
        public bool IsThereABrokenTruck { get; private set; }
        private int BrockenTrucks { get; set; }
        public static void MoveForOneHour ()
>>>>>>> 1931e9ea565b4df590df6486ba7942853d4f40c1
        {
            return distance + velocity;
        }

        public static void SimulateRace(Car[] cars, Moto[] motos, Truck[] trucks)
        {
            for (int i = 1; i <= 50; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    cars[j].DistanceTraveled = MoveForOneHour(cars[j].DistanceTraveled, cars[j].PrepareForLap());
                    motos[j].DistanceTraveled = MoveForOneHour(motos[j].DistanceTraveled, motos[j].PrepareForLap());
                    trucks[j].DistanceTraveled = MoveForOneHour(trucks[j].DistanceTraveled, trucks[j].PrepareForLap());

                }
            }
        }

        public static void PrintRaceResults (Car[] cars, Moto[] motos, Truck[] trucks)
        {
            object[] results = Array.
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
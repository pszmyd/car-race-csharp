

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
            BrokenTrucks = 0;
        }
        public bool IsThereABrokenTruck { get; private set; }
        private int BrokenTrucks { get; set; }
        public static int MoveForOneHour (int distance, int velocity)

        {
            return distance + velocity;
        }

        public static void SimulateRace(Car[] cars, Moto[] motos, Truck[] trucks)
        {
            for (int i = 1; i <= 50; i++)
            {
                bool ActualWeather = Weather.IsRaining();
                for (int j = 0; j < 10; j++)
                {
                    cars[j].DistanceTraveled = MoveForOneHour(cars[j].DistanceTraveled, cars[j].PrepareForLap());
                    motos[j].DistanceTraveled = MoveForOneHour(motos[j].DistanceTraveled, motos[j].PrepareForLap(ActualWeather));
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
            BrokenTrucks += status;
            if (BrokenTrucks > 0)
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
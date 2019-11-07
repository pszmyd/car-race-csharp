using System;

namespace Codecool.CarRace
{
    /// <summary>
    /// This class is for simulating a full race with different vehicles and print race results ot the standard output.
    /// </summary>
    public class Race
    {

        public Race()
        {

        }
        private int BrokenTrucks { get; set; }
        public static int MoveForOneHour(int distance, int velocity)

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

        public static void PrintRaceResults(Car[] cars, Moto[] motos, Truck[] trucks)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Car " + cars[i].Name + " " + cars[i].DistanceTraveled);
                Console.WriteLine("Motorcycle " + motos[i].Name + " " + motos[i].DistanceTraveled);
                Console.WriteLine("Truck " + trucks[i].Name + " " + trucks[i].DistanceTraveled);
            }
        }



    }
}
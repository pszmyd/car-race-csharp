using System;

namespace Codecool.CarRace
{
    class Program
    {
        /// <summary>
        /// Entry point of our program. Creates one race instance and uses that.
        /// </summary>
        /// <param name="args">Commandline arguments passed to the program. It is unused!</param>
        static void Main(string[] args)
        {
            var race = new Race();
            CreateVehicles(race);
            race.SimulateRace();
            race.PrintRaceResults();
        }

        /// <summary>
        /// Creates all the vehicles that will be part of the given race.
        /// </summary>
        /// <param name="race">A <see cref="Race"/> instance.</param>
        public static void CreateVehicles(Race race)
        {
            string[] carNames = Util.GetCarNamesArr();
            string[] truckNames = Util.GetTruckNamesArr();
            string[] motoNames = Util.GetMotoNamesArr();
            Car[] carsArr = new Car[10];
            Moto[] motosArr = new Moto[10];
            Truck[] trucksArr = new Truck[10];

            for (int i = 0; i < 10; i++)
            {
                carsArr[i] = new Car(carNames[i]);
                motosArr[i] = new Moto(motoNames[i]);
                trucksArr[i] = new Truck(truckNames[i]);
            }

            race.GetVehicles(carsArr, motosArr, trucksArr);
        }
    }
}

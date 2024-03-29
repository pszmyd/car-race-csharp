﻿using System;

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

            Car[] car = new Car[10];
            Moto[] moto = new Moto[10];
            Truck[] truck = new Truck[10];

            var race = new Race();

            CreateVehicles(car, moto, truck, race);

            race.SimulateRace(car, moto, truck) ;
            race.PrintRaceResults(car, moto, truck);

        }

        /// <summary>
        /// Creates all the vehicles that will be part of the given race.
        /// </summary>
        /// <param name="race">A <see cref="Race"/> instance.</param>
        public static void CreateVehicles(Car[] cars, Moto[] motos, Truck[] trucks, Race race)
        {

            for (int i = 0; i<10; i++)
            {
                cars[i] = new Car(Util.GetCarName(), race);
            }
            for (int i = 0; i < 10; i++)
            {
                motos[i] = new Moto(Util.GetMotoName(), race);
            }
            for (int i = 0; i < 10; i++)
            {
                trucks[i] = new Truck(Util.RandomNumber(0, 1000).ToString(), race);
            }
        }
        

    }

}

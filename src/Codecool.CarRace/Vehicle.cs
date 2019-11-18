using System;

namespace Codecool.CarRace
{
    public abstract class Vehicle
    {
        public Vehicle(Race race)
        {
            CurrentRace = race;
        }

        public string Name { get; set; }
        public int DistanceTraveled { get; set; }
               
        public Race CurrentRace { get; set; }
       
    }
}

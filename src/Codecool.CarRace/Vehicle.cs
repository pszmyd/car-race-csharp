using System;

namespace Codecool.CarRace
{
    public abstract class Vehicle
    {
        public string Name { get; }
        public int DistanceTraveled { get; set; }

        public void PrepareForLap(Race race) 
        {
        }


    }
}

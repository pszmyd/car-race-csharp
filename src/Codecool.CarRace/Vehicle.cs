using System;

namespace Codecool.CarRace
{
    public abstract class Vehicle
    {
        protected string Name { get; set; }
        public int DistanceTraveled { get; set; }

        public void PrepareForLap(Race race)
        {
        }
        public Race Race { get; set; }
       
    }
}

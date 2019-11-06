using System;

namespace Codecool.CarRace
{
    public abstract class Vehicle
    {
        public string Name { get; set; }
        public int DistanceTraveled { get; set; }

       
        public Race Race { get; set; }
       
    }
}

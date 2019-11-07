using System;

namespace Codecool.CarRace
{
    public abstract class Vehicle
    {
        protected int Speed { get; set; }
        public string Name { get; set; }
        public int DistanceTraveled { get; set; } = 0;

        public void moveForAnHour() 
        {
            DistanceTraveled += Speed;
        }
    }
}

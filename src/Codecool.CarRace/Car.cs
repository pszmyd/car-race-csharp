using System;

namespace Codecool.CarRace
{
    public class Car : Vehicle
    {
        public int NormalSpeed { get; set; }
        public int PrepareForLap()
        {

            int speed;
            if (Truck.BrokenTrucks>0)
            {
                speed = 75;
            }                
            else { speed = NormalSpeed; }
                
            return speed;
        }
        public Car(string name)
        {
            Name = name;
            DistanceTraveled = 0;
            NormalSpeed = Util.RandomNumber(80, 110);

        }
    }
}

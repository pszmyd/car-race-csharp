using System;

namespace Codecool.CarRace
{
    public class Car : Vehicle
    {
        public int NormalSpeed { get; set; }

        public Car(string name, Race race) : base(race)
        {
            Name = name;
            DistanceTraveled = 0;
            NormalSpeed = Util.RandomNumber(80, 110);

        }

        public int PrepareForLap()
        {

            int speed;
            if (CurrentRace.BrokenTrucks > 0)
            {
                speed = 75;
            }                
            else { speed = NormalSpeed; }
                
            return speed;
        }

    }
}

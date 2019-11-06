using System;

namespace Codecool.CarRace
{
    public class Car : Vehicle
    {
        public Car(Race race, string name)
        {
            Name = name
            DistanceTraveled = 0;
            NormalSpeed = Util.RandomNumber(80, 110);
        }


    public int NormalSpeed { get; set; }
        public int PrepareForLap()
        {

            int speed;
            if ()
                speed = 75;
            else
                speed = NormalSpeed;
            return speed;
        }
        public Car(string name)

    }
}

using System;

namespace Codecool.CarRace
{
    public class Car : Vehicle
    {
        public int NormalSpeed { get; set; }

        public Car(string name)
        {
            Name = name;
            DistanceTraveled = 0;
            NormalSpeed = Util.RandomNumber(80, 110);
        }
    }


}

using System;

namespace Codecool.CarRace
{
    public class Car : Vehicle
    {
        public Car(string name)
        {
            Name = name;
            NormalSpeed = Util.RandomNumber(80, 110);
        }

    public int NormalSpeed { get; set; }
        public void PrepareForLap(Race race)
        {
            Speed = NormalSpeed;
            if (race.IsThereABrokenTruck)
            {
                Speed = 75;
            }
        }
    }
}

using System;

namespace Codecool.CarRace
{
    public class Car : Vehicle
    {
        public int NormalSpeed { get; set; }
        public int PrepareForLap()
        {            
            {
                int speed;
                if (Util.ChanceCalculator(5) is true)
                    speed = 75;
                else
                    speed = Util.RandomNumber(80, 110);
                return speed;
            }
        }

        public Car(string name)
        {
            Name = name;
            DistanceTraveled = 0;
            NormalSpeed = Util.RandomNumber(80, 110);
           
        }
    }


}

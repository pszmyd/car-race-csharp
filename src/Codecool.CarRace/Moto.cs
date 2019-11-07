using System;
using System.Collections.Generic;
using System.Text;

namespace Codecool.CarRace
{
    public class Moto : Vehicle
    {
        public static int MotorcycleNumber;
        public Moto(string name)
        {
            DistanceTraveled = 0;
            MotorcycleNumber += 1;
            Name = name;
        }
        public int PrepareForLap(bool ActualWeather)
        {
            if (ActualWeather)
            { return 100 - Util.RandomNumber(5, 50); }
            { return 75; }
        }


    }
}

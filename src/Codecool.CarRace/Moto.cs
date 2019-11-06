using System;
using System.Collections.Generic;
using System.Text;

namespace Codecool.CarRace
{
    class Moto : Vehicle
    {
        public static int MotorcycleNumber;
        Moto(string name)
        {
            DistanceTraveled = 0;
            MotorcycleNumber += 1;
            Name = name;
        }
        public int PrepareForLap()
        {
            if (Weather.IsRaining())
            { return 100 - Util.RandomNumber(5, 50); }
            { return 75; }
        }
    }
}

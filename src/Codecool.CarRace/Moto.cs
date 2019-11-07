using System;
using System.Collections.Generic;
using System.Text;

namespace Codecool.CarRace
{
    public class Moto : Vehicle
    {
        public Moto(string name)
        {
            Speed = 100;
            Name = name;
        }
        public void PrepareForLap(Race race)
        {
            
            if (Weather.IsRaining())
            {
                Speed -= Util.RandomNumber(5, 50);

            } else
            {
                Speed = 100;
            }
        }
    }
}

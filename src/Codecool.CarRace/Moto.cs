﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Codecool.CarRace
{
    public class Moto : Vehicle
    {
        public static int MotorcycleNumber =0;
        public Moto(string name, Race race) : base(race)
        {
            DistanceTraveled = 0;
            MotorcycleNumber += 1;
            Name = name;
        }
        public int PrepareForLap(bool ActualWeather)
        {
            if (ActualWeather)
            { 
                return 100 - Util.RandomNumber(5, 50); 
            }

            return 75;
        }
    }
}

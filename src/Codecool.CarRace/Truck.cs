using System;

namespace Codecool.CarRace
{
    public class Truck : Vehicle
    {
        int BreakDownTurnsLeft;

        public Truck (string name )
        {
            DistanceTraveled = 0;
            Name = name;
            BreakDownTurnsLeft = 0;
        }
        public int PrepareForLap()
            
        { int ReturnValue;
            if (BreakDownTurnsLeft > 0)
            { ReturnValue = 0; } 
            else 
            {ReturnValue =100; };
            
         return  ReturnValue;

        }


    }


}

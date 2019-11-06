using System;

namespace Codecool.CarRace
{
    class Truck : Vehicle
    {
        int BreakDownTurnsLeft;

        Truck (string name )
        {
            DistanceTraveled = 0;
            Name = name;
            BreakDownTurnsLeft = 0;
        }


    }


}

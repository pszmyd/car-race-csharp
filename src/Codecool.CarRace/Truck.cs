using System;

namespace Codecool.CarRace
{
    public class Truck : Vehicle
    {

        public Truck(string name)

        {
            DistanceTraveled = 0;
            Name = name;
            IsBroken = false;

        }
        private bool IsBroken { get; set; }
        private int BreakdownsTurnsLeft { get; set; }

        public int PrepareForLap()
        {
            int percent = 5;
            IsBroken = Util.PercentChanceCalculator(percent);
            if (IsBroken)
            {
                BreakdownsTurnsLeft = 2;
                Race.BrokenTrucksCounter(1);
                return 0;
            }
            else if (BreakdownsTurnsLeft > 0)
            {
                BreakdownsTurnsLeft--;
                return 0;
            }
            else
            {
                BreakdownsTurnsLeft = 0;
                Race.BrokenTrucksCounter(-1);
                return 100;
            }
        }
    }
}

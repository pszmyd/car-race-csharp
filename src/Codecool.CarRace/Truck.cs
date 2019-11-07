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
            ActualSpeed = 100;

        }
        private bool IsBroken { get; set; }
        private int BreakdownsTurnsLeft { get; set; }
        private int ActualSpeed { get; }

        public void PrepareForLap()
        {
            int percent = 5;
            IsBroken = Util.PercentChanceCalculator(percent);
            if (IsBroken)
            {
                BreakdownsTurnsLeft = 2;
                Race.BrokenTrucksCounter(1);
            }
            else if (BreakdownsTurnsLeft > 0)
            {
                BreakdownsTurnsLeft--;
            }
            else
            {
                BreakdownsTurnsLeft = 0;
                DistanceTraveled += ActualSpeed;
                Race.BrokenTrucksCounter(-1);
            }
        }
    }
}

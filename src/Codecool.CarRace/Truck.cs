using System;

namespace Codecool.CarRace
{
    class Truck : Vehicle
    {
        Truck(string name)
        {
            DistanceTraveled = 0;
            Name = name;
            IsBroken = false;
            ActualSpeed = 100;

        }
        private bool IsBroken { get; set; }
        private int WaitingLaps { get; set; }
        private int ActualSpeed { get; }

        public void PrepareForLap()
        {
            int percent = 5;
            IsBroken = Util.PercentChanceCalculator(percent);
            if (IsBroken)
            {
                WaitingLaps = 2;
                Race.BrokenTrucksCounter(1);
            }
            else if (WaitingLaps > 0)
            {
                WaitingLaps--;
            }
            else
            {
                WaitingLaps = 0;
                DistanceTraveled += ActualSpeed;
                Race.BrokenTrucksCounter(-1);
            }
        }
    }
}

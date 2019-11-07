using System;

namespace Codecool.CarRace
{
    public class Truck : Vehicle
    {
        public Truck(string name)
        {
            WaitingLaps = 0;
            DistanceTraveled = 0;
            Name = name;
            IsBroken = false;
            Speed = 100;
        }
        private bool IsBroken { get; set; }
        private int WaitingLaps { get; set; }

        public void PrepareForLap(Race race)
        {
            int percent = 5;
            
            if (WaitingLaps > 0)
            {
                WaitingLaps--;
                if (WaitingLaps == 0)
                {
                    Speed = 100;
                    IsBroken = false;
                    race.BrokenTrucksCounter(-1);
                }
            } else
            {
                IsBroken = Util.PercentChanceCalculator(percent);
                if (IsBroken)
                {
                    WaitingLaps = 2;
                    Speed = 0;
                    race.BrokenTrucksCounter(1);
                }
            }            
        }
    }
}

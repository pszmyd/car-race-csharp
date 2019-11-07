using System;

namespace Codecool.CarRace
{
    public class Truck : Vehicle
    {
        public static int BrokenTrucks = 0;
        public Truck(string name)

        {
            DistanceTraveled = 0;
            Name = name;
            IsBroken = false;
            BreakdownsTurnsLeft = 0;

        }
        private bool IsBroken { get; set; }
        private int BreakdownsTurnsLeft { get; set; }

        public int PrepareForLap()
        {
            int percent = 5;
            if (!IsBroken)
                IsBroken = !(Util.PercentChanceCalculator(percent));
            if (IsBroken && BreakdownsTurnsLeft == 0) // Zepsuł się
            {
                BreakdownsTurnsLeft = 2;
                BrokenTrucks += 1;
                return 0;
            }
            else if (!IsBroken && BreakdownsTurnsLeft == 0) // Jeździ
            { 
                return 100;
            }
            else if (BreakdownsTurnsLeft == 2) // Naprawia się
            {
                BreakdownsTurnsLeft--;
                return 0;
               
            }

            else // Rusza
            {
                BrokenTrucks -= 1;
                BreakdownsTurnsLeft--;
                return 0;
            }
            
        }
    }
}

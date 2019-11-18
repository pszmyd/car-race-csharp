using System;

namespace Codecool.CarRace
{
    public class Truck : Vehicle
    {
        //public static int BrokenTrucks = 0;
        public Truck(string name, Race race) : base(race)

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

            switch(BreakdownsTurnsLeft)
            {
                case 0:
                    if (IsBroken)
                    {

                    }
                    break;
                case 1:
                    break;
                case 2: 
                    break;
                default:
                    break;
            }
            if (IsBroken && BreakdownsTurnsLeft == 0) // Zepsuł się
            {
                BreakdownsTurnsLeft = 2;
                CurrentRace.BrokenTrucks += 1;
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
                CurrentRace.BrokenTrucks -= 1;
                BreakdownsTurnsLeft--;
                return 0;
            }
            
        }
    }
}

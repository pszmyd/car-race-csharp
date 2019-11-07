using System;

namespace Codecool.CarRace
{
    public static class Weather
    {
        private static bool Rain { get; set; }
        public static bool IsRaining()
        {
            return Rain;
        }
        public static void SetRaning()
        {
            Rain = Util.PercentChanceCalculator(30);
        }
    }
}

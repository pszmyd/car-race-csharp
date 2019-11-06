using System;

namespace Codecool.CarRace
{
    public static class Weather
    {
        public static bool IsRaining ()
        {
            return Util.ChanceCalculator(30);
        }
    }
}

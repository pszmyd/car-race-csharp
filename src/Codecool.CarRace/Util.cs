using System;


namespace Codecool.CarRace
{

    
    public static class Util
    {
        public static Random rnd = new Random();
        
        public static int RandomNumber(int Lbound, int Ubound)
        {
            return rnd.Next(Lbound, Ubound);
        }

        public static int NameForTruck (int[] TruckList) // no repetitions in Names of Trucks with using rnd field from Random obj
        {
            return 1;
        }

        public static bool ChanceCalculator(int chance)
        {
            if(chance <= rnd.Next(100))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

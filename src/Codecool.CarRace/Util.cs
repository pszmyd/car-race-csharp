using System;
using System.Text;

namespace Codecool.CarRace
{


    public static class Util
    {
        public static Random rnd = new Random();

        public static int RandomNumber(int Lbound, int Ubound)
        {
            return rnd.Next(Lbound, Ubound);
        }

        public static int NameForTruck(int[] TruckList) // no repetitions in Names of Trucks with using rnd field from Random obj
        {
            return rnd.Next(1001);
        }

        public static bool ChanceCalculator(int chance)
        {
            if (chance <= rnd.Next(100))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static string GetCarName()
        {
            string[] carNamesList = System.IO.File.ReadAllLines(@"..\..\..\carknames.txt");
            StringBuilder carName = new StringBuilder();
            for (int i = 0; i < 2; i++)
            {

                int randNum = rnd.Next(carNamesList.Length);
                carName.Append(carNamesList[randNum]);
                carName.Append(" ");


            }

            return carName.ToString().TrimEnd();
        }
    }
}



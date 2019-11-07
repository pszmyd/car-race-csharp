using System;
using System.Linq;
using System.Text;

namespace Codecool.CarRace
{


    public static class Util
    {
        public static Random rnd = new Random();

        /// <summary>
        /// This function generates a random number between the given values
        /// </summary>
        /// <param name="Lbound">Low bound</param>
        /// <param name="Ubound">High bound</param>
        /// <returns>Random number between the given values</returns>
        public static int RandomNumber(int Lbound, int Ubound)
        {
            return rnd.Next(Lbound, Ubound);
        }

        /// <summary>
        /// This function calculates the probability of occurrence of a single event
        /// </summary>
        /// <param name="percent">Percent chance of occurrence of the event</param>
        /// <returns>True if the event occurred, else false</returns>
        public static bool PercentChanceCalculator(int percent)
        {
            if (percent >= rnd.Next(100))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// This function generate random fake full name
        /// </summary>
        /// <returns>string full name (first ane surename)</returns>
        public static string GetCarName()
        {
            string[] namesFromFile = System.IO.File.ReadAllLines(@"..\..\..\carknames.txt");
            StringBuilder carName = new StringBuilder();
            for (int i = 0; i < 2; i++)
            {
                int randNum = rnd.Next(namesFromFile.Length);
                carName.Append(namesFromFile[randNum]);
                carName.Append(" ");
            }
            return carName.ToString().TrimEnd();
        }
        /// <summary>
        /// This function generate 10 car names
        /// </summary>
        /// <returns>array which 10 car names</returns>
        public static string[] GetCarNamesArr()
        {
            string[] carNames = new string[10];
            int i = 0;
            string name;
            while (i < 10)
            {
                name = GetCarName();
                if (carNames.Contains(name))
                {
                    continue;
                }
                else
                {
                    carNames[i] = name;
                    i++;
                }
            }
            return carNames;
        }

        /// <summary>
        /// This function generate 10 moto names
        /// </summary>
        /// <returns>array which 10 moto names</returns>
        public static string[] GetMotoNamesArr()
        {
            string[] motoNames = new string[10];
            for (int i = 0; i < 10; i++)
            {
                motoNames[i] = $"Motorcycle {i + 1}";
            }
            return motoNames;
        }

        /// <summary>
        /// This function generate 10 truck names
        /// </summary>
        /// <returns>array which 10 moto names</returns>
        public static string[] GetTruckNamesArr()
        {
            string[] truckNames = new string[10];
            int i = 0;
            string name;
            while (i < 10)
            {
                name = $"Truck {RandomNumber(1, 1001)}";
                if (truckNames.Contains(name))
                {
                    continue;
                }
                else
                {
                    truckNames[i] = name;
                    i++;
                }
            }
            return truckNames;
        }
    }

}



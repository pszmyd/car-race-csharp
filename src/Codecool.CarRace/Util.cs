using System;
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
            if (percent <= rnd.Next(100))
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
            string[] namesFromFile = System.IO.File.ReadAllLines(@"../../../carknames.txt");
            StringBuilder carName = new StringBuilder();
            for (int i = 0; i < 2; i++)
            {
                int randNum = rnd.Next(namesFromFile.Length);
                carName.Append(namesFromFile[randNum]);
                carName.Append(" ");
            }
            return carName.ToString().TrimEnd();
        }

        public static string GetMotoName()
        {
            string motoName = "Motorcycle" + Moto.MotorcycleNumber;
            return motoName;
        }
    }
}



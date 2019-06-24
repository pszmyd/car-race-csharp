namespace CarRace.Console
{
    class Program
    {
        /// <summary>
        /// Entry point of our program. Creates one race instance and uses that.
        /// </summary>
        /// <param name="args">Commandline arguments passed to the program. It is unused!</param>
        static void Main(string[] args)
        {
            Race race = new Race();
            CreateVehicles(race);

            //race.SimulateRace();
            //race.PrintRaceResults();
        }

        /// <summary>
        /// Creates all the vehicles that will be part of the given race.
        /// </summary>
        /// <param name="race">A <see cref="Race"/> instance.</param>
        public static void CreateVehicles(Race race)
        {

        }
    }

}

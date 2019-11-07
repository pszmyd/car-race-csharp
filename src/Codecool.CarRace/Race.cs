namespace Codecool.CarRace
{
    /// <summary>
    /// This class is for simulating a full race with different vehicles and print race results ot the standard output.
    /// </summary>
    public class Race
    {
        public Race()
        {
            IsThereABrokenTruck = false;
            BrockenTrucks = 0;
        }
        public bool IsThereABrokenTruck { get; private set; }
        private int BrockenTrucks { get; set; }
        private Car[] cars;
        private Moto[] motos;
        private Truck[] trucks;
        
        public void SimulateRace() 
        { 
            for (int i = 0; i<50; i++)
			{
                Weather.SetRaning();
                foreach (var item in trucks)
                {
                    item.PrepareForLap(this);
                    item.moveForAnHour();
                }
                foreach (var item in cars)
                {
                    item.PrepareForLap(this);
                    item.moveForAnHour();
                }
                foreach (var item in motos)
                {
                    item.PrepareForLap(this);
                    item.moveForAnHour();
                }
			}
        }

        public void PrintRaceResults ()
        {
            foreach (var item in trucks)
            {
                System.Console.WriteLine($"{item.Name} has traveled a distance {item.DistanceTraveled}");
            }
            foreach (var item in cars)
            {
                System.Console.WriteLine($"{item.Name} has traveled a distance {item.DistanceTraveled}");
            }
            foreach (var item in motos)
            {
                System.Console.WriteLine($"{item.Name} has traveled a distance {item.DistanceTraveled}");
            }
        }

        public void BrokenTrucksCounter (int status) 
        {
            BrockenTrucks += status;

            if (BrockenTrucks > 0)
            {
                IsThereABrokenTruck = true;
            }
            else
            {
                IsThereABrokenTruck = false;
            }
        }
        
        public void GetVehicles(Car[] cars, Moto[] motos, Truck[] trucks)
        {
            this.cars = cars;
            this.motos = motos;
            this.trucks = trucks;
        }

    }
}
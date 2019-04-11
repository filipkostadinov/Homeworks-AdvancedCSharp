using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Parking<IVehicle> poc = new Parking<IVehicle>(100);
            Car astra = new Car
            {
                Make = "Opel",
                Model = "Astra"
            };

            poc.ParkVehicle(astra, poc);

            //astra.LeaveParking();

            Parking<IVehicle> marina = new Parking<IVehicle>(50);
            Boat jenny = new Boat() { Name = "Jenny", BesPlatno = true };

            marina.ParkVehicle(jenny, marina);

            Console.WriteLine(marina.FreeCapacity);
            Console.WriteLine(marina.Occupancy);
            Console.WriteLine(poc.FreeCapacity);
        }
    }
}

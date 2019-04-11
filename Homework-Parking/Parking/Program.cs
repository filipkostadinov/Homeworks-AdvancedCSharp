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
            Parking<Car> poc = new Parking<Car>(100);
            Car astra = new Car
            {
                Make = "Opel",
                Model = "Astra"
            };

            poc.ParkVehicle(astra);

            astra.LeaveParking();

            Parking<Boat> marina = new Parking<Boat>(50);
            Boat jenny = new Boat() { Name = "Jenny", BesPlatno = true };

            marina.ParkVehicle(jenny);

        }
    }
}

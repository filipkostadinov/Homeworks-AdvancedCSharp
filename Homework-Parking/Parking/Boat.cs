using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingProject
{
    public class Boat
    {
        public string Name { get; set; }
        public bool BesPlatno { get; set; }
        public Parking<Boat> Parking { get; set; }
    }
}

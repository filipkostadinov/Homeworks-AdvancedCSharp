﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingProject
{
    public class Parking<T> where T : IVehicle
    {
        public int Capacity { get; private set; }
        public int Occupancy { get; private set; }
        public int FreeCapacity
        {
            get
            {
                return Capacity - Occupancy;
            }
        }

        private List<T> parkedVehicles = new List<T>();

        public Parking(int capacity)
        {
            Capacity = capacity;
            Occupancy = 0;
        }

        public void ParkVehicle(T vehicle, Parking<IVehicle> parking)
        {
            if (FreeCapacity > 0)
            {
                Occupancy += 1;
                parkedVehicles.Add(vehicle);
                vehicle.Parking = parking;

            }
        }

        public void LeaveVehicle(T vehicle)
        {
            if (parkedVehicles.Contains(vehicle))
            {
                Occupancy -= 1;
                parkedVehicles.Remove(vehicle);

                vehicle.Parking = null; // *
            }
        }

    }
}

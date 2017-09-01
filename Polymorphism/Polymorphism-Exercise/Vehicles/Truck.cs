﻿namespace Vehicles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Truck : Vehicle
    {
        private const double AcConsumptionMod = 1.6;
        private const double FuelLostFactor = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapcity)
            :base(fuelQuantity, fuelConsumption + AcConsumptionMod, tankCapcity)
        {
        }

        public override void Refuel(double fuelAmount)
        {
            base.Refuel(fuelAmount * FuelLostFactor);
        }
    }
}

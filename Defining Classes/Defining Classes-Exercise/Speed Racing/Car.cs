namespace Speed_Racing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Car
    {
        private string model;

        private double fuelAmount;

        private double fuelCost;

        private double distanceTraveled;

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }

        public double FuelCost
        {
            get { return this.fuelCost; }
            set { this.fuelCost = value; }
        }

        public double DistanceTraveled
        {
            get { return this.distanceTraveled; }
            set { this.distanceTraveled = value; }
        }

        public Car()
        {
            this.DistanceTraveled = 0.0;
        }

        public double CurrentDistance(double km)
        {
            var currentDistance = this.fuelCost * km;

            return currentDistance;
        }
    }
}

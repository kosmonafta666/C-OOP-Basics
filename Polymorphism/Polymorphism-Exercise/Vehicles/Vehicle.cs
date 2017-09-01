namespace Vehicles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Vehicle
    {        
        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapcity)
        {
            this.TankCapacity = tankCapcity;

            this.FuelQuantity = fuelQuantity;

            this.FuelConsumption = fuelConsumption;          
        }

        protected virtual double FuelQuantity
        {
            get; set;
        }

        protected double FuelConsumption
        {
            get; set;
        }

        protected virtual double TankCapacity
        {
            get; set;
        }

        protected virtual bool Drive(double distance, bool isAcOn)
        {
            var fuelRequired = distance * this.FuelConsumption;

            if (fuelRequired <= this.FuelQuantity)
            {
                this.FuelQuantity -= fuelRequired;
                return true;
            }

            return false;
        }

        public string TryTravelDistance(double distance, bool isAcOn)
        {
            if (Drive(distance, isAcOn))
            {
                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }

        public string TryTravelDistance(double distance)
        {
            return this.TryTravelDistance(distance, true);
        }

        public virtual void Refuel(double fuelAmount)
        {
            if (fuelAmount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            this.FuelQuantity += fuelAmount;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}

namespace Vehicles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Bus : Vehicle
    {
        private const double AcConsumptionMod = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapcity)
            :base(fuelQuantity, fuelConsumption, tankCapcity)
        {
        }

        protected override double FuelQuantity
        {  
            set
            {
                if (value > this.TankCapacity)
                {
                    throw new ArgumentException("Cannot fit fuel in tank");
                }

                base.FuelQuantity = value;
            }
        }

        protected override bool Drive(double distance, bool isAcOn)
        {
            double requeredFuel = 0;

            if (isAcOn)
            {
                requeredFuel = distance * (this.FuelConsumption + AcConsumptionMod);
            }
            else
            {
                requeredFuel = distance * this.FuelConsumption;
            }

            if (requeredFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= requeredFuel;
                return true;
            }

            return false;
        }
    }
}

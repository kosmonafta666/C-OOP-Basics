namespace Wild_farm.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Mamal : Animal
    {
        private string livingRegion;

        protected string LivingRegion
        {
            get { return this.livingRegion; }

            set
            {
                this.livingRegion = value;
            }
        }

        protected Mamal(string animalType, string animalName, double animalWeight, string livingRegion)
            :base (animalType, animalName, animalWeight)
        {
            this.LivingRegion = livingRegion;
        }

        public override string ToString()
        {
            return $"{this.AnimalType}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}

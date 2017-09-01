namespace Wild_farm.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Wild_farm.Foods;

    public abstract class Animal
    {
        private string animalType;
        private string animalName;
        private double animalWeight;
        private int footEaten;

        protected string AnimalType
        {
            get { return this.animalType; }

            set
            {
                this.animalType = value;
            }
        }

        protected string AnimalName
        {
            get { return this.animalName; }

            set
            {
                this.animalName = value;
            }
        }

        protected double AnimalWeight
        {
            get { return this.animalWeight; }

            set
            {
                this.animalWeight = value;
            }
        }

        protected int FoodEaten
        {
            get { return this.footEaten; }

            set
            {
                this.footEaten = value;
            }
        }

        protected Animal(string animalType, string animalName, double animalWeight)
        {
            this.animalType = animalType;

            this.AnimalName = animalName;

            this.AnimalWeight = animalWeight;
        }

        public abstract void MakeSound();

        public abstract void Eat(Food food);
    }
}

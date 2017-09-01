namespace Wild_farm.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Wild_farm.Foods;

    public class Cat : Felime
    {
        private string breed;

        public string Breed
        {
            get { return this.breed; }

            set
            {
                this.breed = value;
            } 
        }

        public Cat(string animalType, string animalName, double animalWeight, string livingRegion, string breed)
            :base(animalType, animalName, animalWeight, livingRegion)
        {
            this.Breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return $"{this.AnimalType}[{this.AnimalName}, {this.Breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}

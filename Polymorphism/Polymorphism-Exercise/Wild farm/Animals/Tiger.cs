namespace Wild_farm.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Wild_farm.Foods;

    public class Tiger : Felime
    {
        public Tiger(string animalType, string animalName, double animalWeight, string livingRegion)
            :base(animalType, animalName, animalWeight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Meat")
            {
                throw new ArgumentException($"{this.AnimalType}s are not eating that type of food!");
            }

            this.FoodEaten += food.Quantity;
        }
    }
}

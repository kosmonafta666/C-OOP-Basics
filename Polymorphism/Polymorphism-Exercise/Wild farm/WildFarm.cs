namespace Wild_farm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Wild_farm.Animals;
    using Wild_farm.Foods;

    public class WildFarm
    {
        static void Main(string[] args)
        {
            //read the animal line;
            string animalLine;

            while((animalLine = Console.ReadLine()) != "End")
            {
                //var for splited animal line;
                var tokens = animalLine.Split(' ');

                //var for animal type;
                var type = tokens[0];
                //var for animal name;
                var name = tokens[1];
                //var for animal weight;
                var weight = double.Parse(tokens[2]);
                //var for animal living region;
                var region = tokens[3];

                //create the current animal;
                Animal currentAnimal = null;

                if (tokens.Length == 5)
                {
                    //create cat;
                    currentAnimal = new Cat(type, name, weight, region, tokens[4]);
                }
                else
                {
                    switch (tokens[0])
                    {
                        case "Mouse":
                            currentAnimal = new Mouse(type, name, weight, region);
                            break;
                        case "Zebra":
                            currentAnimal = new Zebra(type, name, weight, region);
                            break;
                        case "Tiger":
                            currentAnimal = new Tiger(type, name, weight, region);
                            break;
                    }
                }//end of creation of the current animal;

                //read the food line;
                var foodLine = Console.ReadLine().Split(' ');

                //var for food type;
                var foodType = foodLine[0];
                //var for food quantity;
                var foodQuatity = int.Parse(foodLine[1]);

                //create current food;
                Food currentFood = null;

                if (foodType == "Vegetable")
                {
                    currentFood = new Vegetable(foodQuatity);
                }
                else if (foodType == "Meat")
                {
                    currentFood = new Meat(foodQuatity);
                }

                //print the sound of current animal;
                currentAnimal.MakeSound();

                //food the current animal;
                try
                {
                    currentAnimal.Eat(currentFood);
                }
                catch (ArgumentException er)
                {
                    Console.WriteLine(er.Message);
                }

                //print the infomation for teh current animal;
                Console.WriteLine(currentAnimal);

            }//end of while loop;
        }
    }
}

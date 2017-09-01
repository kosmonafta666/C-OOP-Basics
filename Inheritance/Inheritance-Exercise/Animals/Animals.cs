namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Animals
    {
        public static void Main(string[] args)
        {
            //list for the animals;
            var animals = new List<Animal>();

            string command;

            while ((command = Console.ReadLine()) != "Beast!")
            {
                try
                {
                    //read the animal input;
                    var animalLine = Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    //var for age of the animal;
                    var age = 0;

                    if (!int.TryParse(animalLine[1], out age))
                    {
                        throw new ArgumentException("Invalid input!");
                    }

                    //var for name of the animal;
                    var name = animalLine[0];
                    //var for gender of the animal;
                    var gender = animalLine[2];

                    switch(command)
                    {
                        case "Cat":
                           animals.Add(new Cat(name, age, gender));
                           break;
                        case "Dog":
                            animals.Add(new Dog(name, age, gender));
                            break;
                        case "Frog":
                            animals.Add(new Frog(name, age, gender));
                            break;
                        case "Kitten":
                            animals.Add(new Kitten(name, age));
                            break;
                        case "Tomcat":
                            animals.Add(new Tomcat(name, age));
                            break;
                        default:
                            throw new ArgumentException("Invalid input!");
                            break;
                    }
                }
                catch(ArgumentException er)
                {
                    Console.WriteLine(er.Message);
                }
            }//end of while loop;

            //print the result;
            animals.ForEach(x => Console.WriteLine(x));
        }
    }
}

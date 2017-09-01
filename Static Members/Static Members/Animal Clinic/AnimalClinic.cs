using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Clinic
{
    public class Animal
    {
        public string name;

        public string breed;

        public Animal(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
        }
    }

    public class Animals
    {
        public static int patientId;

        public static List<Animal> healedAnimalsCount;

        public static List<Animal> rehabilitedAnimalsCount;

        static Animals()
        {
            patientId = 0;

            healedAnimalsCount = new List<Animal>();

            rehabilitedAnimalsCount = new List<Animal>();
        }

        public Animals()
        {
            patientId++;
        }

        public static void printHealed()
        {
            if (healedAnimalsCount.Any())
            {
                foreach (var animal in healedAnimalsCount)
                {
                    Console.WriteLine("{0} {1}", animal.name, animal.breed);
                }
            }
        }

        public static void printRehabilitated()
        {
            if (rehabilitedAnimalsCount.Any())
            {
                foreach (var animal in rehabilitedAnimalsCount)
                {
                    Console.WriteLine("{0} {1}", animal.name, animal.breed);
                }
            }
        }
     }

    public class AnimalClinic
    {
        public static void Main(string[] args)
        {
            //read the input;
            var input = Console.ReadLine();

            while (input != "End")
            {
                //var for splited input;
                var token = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                //var name of the animal;
                var name = token[0];

                //var for breed of the animal;
                var breed = token[1];

                //var for procedure of the animal;
                var procedure = token[2];

                //var for currentAnimal;
                var currentAnimal = new Animal(name, breed);

                //check for procedure;
                if (procedure == "heal")
                {
                    Animals.healedAnimalsCount.Add(currentAnimal);
                    Animals.patientId++;
                    //print the procedure;
                    Console.WriteLine($"Patient {Animals.patientId}: [{name} ({breed})] has been healed!");
                }
                else if (procedure == "rehabilitate")
                {
                    Animals.rehabilitedAnimalsCount.Add(currentAnimal);
                    Animals.patientId++;
                    //print the procedure;
                    Console.WriteLine($"Patient {Animals.patientId}: [{name} ({breed})] has been rehabilitated!");
                }               

                input = Console.ReadLine();
            }//end of while loop;

            Console.WriteLine("Total healed animals: {0}", Animals.healedAnimalsCount.Count);

            Console.WriteLine("Total rehabilitated animals: {0}", Animals.rehabilitedAnimalsCount.Count);

            //read the procedure to print;
            var procedureToPrint = Console.ReadLine();

            //check for procedure and print animals;
            if (procedureToPrint == "heal")
            {
                Animals.printHealed();
            }
            else if (procedureToPrint == "rehabilitate")
            {
                Animals.printRehabilitated();
            }
        }
    }
}

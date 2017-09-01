namespace Cat_Lady
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CatLady
    {
        public static void Main(string[] args)
        {
            //list for all cats;
            var cats = new List<Cat>();

            //read the command line;
            string inputLine;

            while ((inputLine = Console.ReadLine()) != "End")
            {
                //split the input line;
                var tokens = inputLine.Split(' ');

                //var for the name of the current cat;
                var name = tokens[1];
                //var for the breed of the current cat;
                var breed = tokens[0];
                //var for personal data of the current cat;
                var personalData = tokens[2];

                //create current cat and add to list of cats;
                var currentCat = new Cat(name, breed, personalData);

                cats.Add(currentCat);
            }//end of while loop;

            //read the name of the cat to print;
            var catName = Console.ReadLine();

            //cat to print;
            var catToPrint = cats
                .Where(x => x.Name == catName)
                .FirstOrDefault();

            Console.WriteLine(catToPrint);

        }
    }
}

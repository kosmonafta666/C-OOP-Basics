namespace Beer_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BeerCounter
    {
        public static int beerInStock;

        public static int beersDrankCount;

        static BeerCounter()
        {
        }

        public static void BuyBeer(int bottlesCount)
        {
            beerInStock += bottlesCount;
        }

        public static void DrinkBeer(int bottlesCount)
        {
            beersDrankCount += bottlesCount;
            beerInStock -= bottlesCount;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            //read the input;
            var input = Console.ReadLine();

            while(input != "End")
            {
                //var for splitted input;
                var token = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                //var for buy beers
                var buyBeers = int.Parse(token[0]);
                //increment the beer in stock;
                BeerCounter.BuyBeer(buyBeers);

                //var for drinking beer;
                var drinkingBeer = int.Parse(token[1]);
                //increment the drunking beer;
                BeerCounter.DrinkBeer(drinkingBeer);

                input = Console.ReadLine();
            }


            //print thr result;
            Console.Write("{0} ", BeerCounter.beerInStock);
            Console.WriteLine("{0}", BeerCounter.beersDrankCount);
        }
    }
}

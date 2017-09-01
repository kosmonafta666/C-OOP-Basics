namespace Speed_Racing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SpeedRacing
    {
        public static void Main(string[] args)
        {
            //read the nuber of cars;
            var n = int.Parse(Console.ReadLine());

            //list for cars;
            var cars = new List<Car>();

            //read the cars;
            for (int i = 1; i <= n; i++)
            {
                //read the current command;
                var currentCommand = Console.ReadLine()
                    .Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                //var for model of the car;
                var model = currentCommand[0];
                //var for amount of fuel of the car;
                var fuelAmount = double.Parse(currentCommand[1]);
                //var for fuel cost;
                var fuelCost = double.Parse(currentCommand[2]);

                //create the current car;
                var currentCar = new Car
                {
                    Model = model,
                    FuelAmount = fuelAmount,
                    FuelCost = fuelCost
                };

                cars.Add(currentCar);
            }//end of reading the cars;

            //var for drive command;
            var drive = Console.ReadLine();

            while (drive != "End")
            {
                //var for current drive command;
                var token = drive
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                //check for valid command;
                if (token[0] == "Drive")
                {
                    //var for model of a car;
                    var model = token[1];
                    //var for km to travelled;
                    var km = double.Parse(token[2]);

                    //extract car from cars list;
                    var currentCar = cars
                        .Where(x => x.Model == model)
                        .FirstOrDefault();

                    //check if have sufficient fuel to travel the km;
                    if (currentCar.CurrentDistance(km) > currentCar.FuelAmount)
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }
                    else
                    {
                        currentCar.DistanceTraveled += km;
                        currentCar.FuelAmount -= currentCar.CurrentDistance(km);
                    }
                }

                drive = Console.ReadLine();
            }

            //printing the result;
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.DistanceTraveled}");
            }
        }
    }
}

namespace Car_Salesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Car
    {
        public string model;

        public Engine engine;

        public int weight;

        public string color;

        public Car (string model, Engine engine)
            : this(model, engine, -1, @"n/a")
        {

        }

        public Car (string model, Engine engine, int weight)
            : this (model, engine, weight, @"n/a")
        {

        }

        public Car (string model, Engine engine, string color)
            : this(model, engine, -1, color)
        {

        }

        public Car(string model, Engine engine, int weight, string color) 
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.color = color;
        }
    }

    public class Engine
    {
        public string model;

        public int power;

        public int displacement;

        public string efficiency;

        public Engine (string model, int power) 
            : this(model, power, -1, @"n/a")
        {
            
        }

        public Engine (string model, int power, int dispalcement)
            : this (model, power, dispalcement, @"n/a")
        {

        }

        public Engine (string model, int power, string efficiency)
            :this (model, power, -1, efficiency)
        {

        }

        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.model = model;
            this.power = power;
            this.displacement = displacement;
            this.efficiency = efficiency;
        }
    }

    public class CarSalesman
    {
        public static void Main(string[] args)
        {
            //read the number of engines;
            var numberOfEngines = int.Parse(Console.ReadLine());

            //list for engine objects;
            var engines = new List<Engine>();

            //list for car objects;
            var cars = new List<Car>();

            //creating the engines;
            for (int i = 1; i <= numberOfEngines; i++)
            {
                //read the current command;
                var command = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                //var for current engine;
                Engine currentEngine = null;

                //var for model of the engine;
                var model = command[0];

                //var for displacement of the engine;
                var displacement = 0;

                //var for power of the engine;
                var power = int.Parse(command[1]);

                //check of command length;
                if (command.Length == 2)
                {
                    currentEngine = new Engine(model, power);
                }
                else if (command.Length == 4)
                {
                    displacement = int.Parse(command[2]);

                    //var for efficiency of the engine;
                    var efficiency = command[3];

                    currentEngine = new Engine(model, power, displacement, efficiency);
                }
                else if (command.Length == 3)
                {
                    if (int.TryParse(command[2], out displacement))
                    {
                        currentEngine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        currentEngine = new Engine(model, power, command[2]);
                    }
                }//enf of check of command  length;

                //add current engine to enines list;
                engines.Add(currentEngine);
            }//end of creating the engines objects;

            //read the number of cars;
            var numberOfCar = int.Parse(Console.ReadLine());

            //creating the cars;
            for (int i = 1; i <= numberOfCar; i++)
            {
                //read the current command;
                var command = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                //var for current car;
                Car currentCar = null;

                //var for model of the car;
                var model = command[0];

                //var for engine of the car;
                var engine = engines
                    .Where(x => x.model == command[1])
                    .FirstOrDefault();

                //var for weight of the car;
                var weight = 0;

                //check the command length;
                if (command.Length == 2)
                {
                    currentCar = new Car(model, engine);
                }
                else if (command.Length == 4)
                {
                    //var for color of the car;
                    var color = command[3];

                    weight = int.Parse(command[2]);

                    currentCar = new Car(model, engine, weight, color);
                }
                else if (command.Length == 3)
                {
                    if (int.TryParse(command[2], out weight))
                    {
                        currentCar = new Car(model, engine, weight);
                    }
                    else
                    {
                        currentCar = new Car(model, engine, command[2]);
                    }
                }//enf of check for command length;

                //add current car to cars list;
                cars.Add(currentCar);
            }

            //printing the result;
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.model}:");

                Console.WriteLine($"  {car.engine.model}:");

                Console.WriteLine($"    Power: {car.engine.power}");
                Console.WriteLine(car.engine.displacement != -1 ? $"    Displacement: {car.engine.displacement}" : $"    Displacement: n/a");
                Console.WriteLine($"    Efficiency: {car.engine.efficiency}");

                Console.WriteLine(car.weight != -1 ? $"  Weight: {car.weight}" : $"  Weight: n/a");
                Console.WriteLine($"  Color: {car.color}");
            }
        }
    }
}

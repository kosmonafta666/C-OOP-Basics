namespace Raw_Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Car
    {
        private string model;

        private Engine engine;

        private Cargo cargo;

        private Tire[] tires;

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public Cargo Cargo
        {
            get { return this.cargo; }
            set { this.cargo = value; }
        }

        public Engine Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        public Tire[] Tires
        {
            get { return this.tires; }
            set { this.tires = value; }
        }

        public Car (string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.tires = tires;
        }
    }

    public class Engine
    {
        private int speed;

        private int power;

        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

        public int Power
        {
            get { return this.power; }
            set { this.power = value; }
        }

        public Engine (int speed, int power)
        {
            this.speed = speed;
            this.power = power;
        }
    }

    public class Cargo
    {
        private string type;

        private double weight;

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public Cargo (double weight, string type)
        {
            this.weight = weight;
            this.type = type;
        }
    }

    public class Tire
    {
        private int age;

        private double pressure;

        public int Age
        {
            get { return this.Age; }
            set { this.age = value; }
        }

        public double Pressure
        {
            get { return this.pressure; }
            set { this.pressure = value; }
        }

        public Tire (double pressure, int age)
        {
            this.age = age;
            this.pressure = pressure;
        }
    }

    public class RawData
    {
        public static void Main(string[] args)
        {
            //read the number of cars;
            var n = int.Parse(Console.ReadLine());

            //list for the cars;
            var cars = new List<Car>();

            for (int i = 1; i <= n; i++)
            {
                //read the car details;
                var carDetails = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                //var for model;
                var carModel = carDetails[0];

                //var for engine speed;
                var engineSpeed = int.Parse(carDetails[1]);
                //var for engine power;
                var enginePower = int.Parse(carDetails[2]);
                //create engine object;
                var engine = new Engine(engineSpeed, enginePower);

                //var for cargo weight;
                var cargoWeight = double.Parse(carDetails[3]);
                //var for cargo type;
                var cargoType = carDetails[4];
                //create cargo object;
                var cargo = new Cargo(cargoWeight, cargoType);

                //var for tire1 pressure;
                var tire1P = double.Parse(carDetails[5]);
                //var for tire1 age;
                var tire1A = int.Parse(carDetails[6]);
                //create tire1 object;
                var tire1 = new Tire(tire1P, tire1A);

                //var for tire2 pressure;
                var tire2P = double.Parse(carDetails[7]);
                //var for tire2 age;
                var tire2A = int.Parse(carDetails[8]);
                //create tire2 object;
                var tire2 = new Tire(tire2P, tire2A);

                //var for tire3 pressure;
                var tire3P = double.Parse(carDetails[9]);
                //var for tire3 age;
                var tire3A = int.Parse(carDetails[10]);
                //create tire3 object;
                var tire3 = new Tire(tire3P, tire3A);

                //var for tire4 pressure;
                var tire4P = double.Parse(carDetails[11]);
                //var for tire4 age;
                var tire4A = int.Parse(carDetails[12]);
                //create tire4 object;
                var tire4 = new Tire(tire4P, tire4A);

                //create tires array and initializing;
                var tires = new Tire[4];
                tires[0] = tire1;
                tires[1] = tire2;
                tires[2] = tire3;
                tires[3] = tire4;

                //create car object;
                var currentCar = new Car(carModel, engine, cargo, tires);

                //add current car to cars list;
                cars.Add(currentCar);
            }//end of for loop;

            //read the cargo type;
            var cargoTypeMatch = Console.ReadLine();

            //list for sorted cars;
            var sortedCars = new List<Car>();

            //check the type of cargo and initalizing the sorted cars list;
            if (cargoTypeMatch == "fragile")
            {
                sortedCars = cars
                    .Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(p => p.Pressure < 1))
                    .ToList();
            }
            else if (cargoTypeMatch == "flamable")
            {
                sortedCars = cars
                    .Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250)
                    .ToList();
            }

            //printing the result;
            foreach (var car in sortedCars)
            {
                Console.WriteLine("{0}", car.Model);
            }
        }
    }
}

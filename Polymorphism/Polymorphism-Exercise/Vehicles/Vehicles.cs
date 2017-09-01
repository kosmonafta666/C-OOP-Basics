namespace Vehicles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Vehicles
    {
        public static void Main(string[] args)
        {
           
            //read the car line and create it;
            var carLine = Console.ReadLine()
                .Split(' ');

            Vehicle car = new Car(double.Parse(carLine[1]), double.Parse(carLine[2]), double.Parse(carLine[3]));

            //read the truck line and create it;
            var truckLine = Console.ReadLine()
                .Split(' ');

            Vehicle truck = new Truck(double.Parse(truckLine[1]), double.Parse(truckLine[2]), double.Parse(truckLine[3]));

            //read the bus line and create it;
            var busLine = Console.ReadLine()
                .Split(' ');

            Vehicle bus = new Bus(double.Parse(busLine[1]), double.Parse(busLine[2]), double.Parse(busLine[3]));

            //read the commands count;
            var commandNumber = int.Parse(Console.ReadLine());

            //read the commands;
            for (int i = 0; i < commandNumber; i++)
            {
                try
                {
                    //read the current command;
                    var tokens = Console.ReadLine()
                        .Split(' ');

                    //var for vehicle type;
                    var vehicleType = tokens[1];

                    //check for vehicle type and execute the given commnad;
                    if (vehicleType == "Car")
                    {
                        ExecutionAction(car, tokens[0], double.Parse(tokens[2]));
                    }
                    else if (vehicleType == "Truck")
                    {
                        ExecutionAction(truck, tokens[0], double.Parse(tokens[2]));
                    }
                    else if (vehicleType == "Bus")
                    {
                        ExecutionAction(bus, tokens[0], double.Parse(tokens[2]));
                    }
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //print the car and truck;
            Console.WriteLine(car);

            Console.WriteLine(truck);

            Console.WriteLine(bus);
        }

        //method to execute certain command to vehicle type;
        private static void ExecutionAction(Vehicle vehicle, string command, double parametar)
        {
            switch(command)
            {
                case "Drive":
                    Console.WriteLine(vehicle.TryTravelDistance(parametar));
                    break;
                case "Refuel":
                    vehicle.Refuel(parametar);
                    break;
                case "DriveEmpty":
                    Console.WriteLine(vehicle.TryTravelDistance(parametar, false));
                    break;
            }
        }
    }
}

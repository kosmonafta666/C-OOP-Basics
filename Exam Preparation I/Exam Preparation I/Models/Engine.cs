using System;

public class Engine
{
    private CarManager manager;

    public Engine()
    {
        this.manager = new CarManager();
    }

    public void Run()
    {
        string command;

        while ((command = Console.ReadLine())!= "Cops Are Here")
        {
            var cmdArgs = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            ExecuteCommand(cmdArgs);
        }
    }

    public void ExecuteCommand(string[] cmdArgs)
    {
        switch (cmdArgs[0])
        {
            case "register":
                int id = int.Parse(cmdArgs[1]);
                string type = cmdArgs[2];
                string brand = cmdArgs[3];
                string model = cmdArgs[4];
                int yearOfProduction = int.Parse(cmdArgs[5]);
                int horsePower = int.Parse(cmdArgs[6]);
                int acceleration = int.Parse(cmdArgs[7]);
                int suspension = int.Parse(cmdArgs[8]);
                int durability = int.Parse(cmdArgs[9]);
                manager.Register(id, type, brand, model, yearOfProduction, horsePower, 
                    acceleration, suspension, durability);
                break;

            case "check":
                Console.WriteLine(manager.Check(int.Parse(cmdArgs[1])));
                break;

            case "open":
                id = int.Parse(cmdArgs[1]);
                type = cmdArgs[2];
                int lenght = int.Parse(cmdArgs[3]);
                var route = cmdArgs[4];
                int prizePool = int.Parse(cmdArgs[5]);
                manager.Open(id, type, lenght, route, prizePool);
                break;

            case "participate":
                int carId = int.Parse(cmdArgs[1]);
                int raceId = int.Parse(cmdArgs[2]);
                manager.Participate(carId, raceId);
                break;

            case "start":
                Console.WriteLine(manager.Start(int.Parse(cmdArgs[1])));
                break;

            case "park":
                manager.Park(int.Parse(cmdArgs[1]));
                break;

            case "unpark":
                manager.Unpark(int.Parse(cmdArgs[1]));
                break;

            case "tune":
                int tuneIndex = int.Parse(cmdArgs[1]);
                var addOns = cmdArgs[2];
                manager.Tune(tuneIndex, addOns);
                break;
        }
    }
}


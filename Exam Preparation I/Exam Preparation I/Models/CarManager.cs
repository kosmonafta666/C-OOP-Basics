using System;
using System.Collections.Generic;
using System.Linq;

public class CarManager
{
    private Dictionary<int, Car> cars;
    private Dictionary<int, Race> races;
    private Garage garage;
    private List<int> closedRaces;

    public Dictionary<int, Car> Cars
    {
        get { return this.cars; }
        set
        {
            this.cars = value;
        }
    }

    public Dictionary<int, Race> Races 
    {
        get { return this.races; }
        set
        {
            this.races = value;
        }
    }

    public Garage Garage
    {
        get { return this.garage; }
        set
        {
            this.garage = value;
        }
    }

    public CarManager()
    {
        this.Cars = new Dictionary<int, Car>();
        this.Races = new Dictionary<int, Race>();
        this.Garage = new Garage();
        this.closedRaces = new List<int>();
    }

    //register the car by givven parameters;
    public void Register(int id, string type, string brand, string model, 
        int yearOfProduction, int horsePower, int acceleration, int suspension, int durability)
    {
        switch (type)
        {
            case "Performance":
                this.Cars.Add(id, new PerformanceCar(brand, model, yearOfProduction,
                    horsePower, acceleration, suspension, durability));
                break;
            case "Show":
                this.Cars.Add(id, new ShowCar(brand, model, yearOfProduction,
                    horsePower, acceleration, suspension, durability));
                break;               
        }
    }

    //return the car details by givven id;
    public string Check(int id)
    {
        return this.Cars[id].ToString();
    }

    //open the race by givven parametars;
    public void Open(int id, string type, int length, string route, int prizePool)
    {
        switch (type)
        {
            case "Casual":
                this.Races.Add(id, new CasualRace(length, route, prizePool));
                break;
            case "Drag":
                this.Races.Add(id, new DragRace(length, route, prizePool));
                break;
            case "Drift":
                this.Races.Add(id, new DriftRace(length, route, prizePool));
                break;
        }
    }

    //add car to given race;
    public void Participate(int carId, int raceId)
    {
        //var for car by given id;
        Car car = this.Cars[carId];
        //var for race by given id;
        Race race = this.Races[raceId];

        if (!this.Garage.ParkedCars.Contains(carId))
        {
            if (!this.closedRaces.Contains(raceId))
            {
                race.Participants.Add(carId, car);
            }                          
        }             
    }

    //return details about race by given id;
    public string Start(int id)
    {
        if (this.Races[id].Participants.Count == 0)
        {
            return "Cannot start the race with zero participants.";
        }
        var result = this.Races[id].StartRace();

        this.closedRaces.Add(id);
        
        return result;
    }

    //park the car by given id;
    public void Park(int id)
    {
        foreach (var race in this.Races.Where(x => !this.closedRaces.Contains(x.Key)))
        {
            if (race.Value.Participants.ContainsKey(id))
            {
                return;
            }
        }

        this.Garage.AddCar(id);
    }

    //unpark the car by given id;
    public void Unpark(int id)
    {
        this.Garage.RemoveCar(id);
    }

    //tune up all parked cars in garage by given parametars;
    public void Tune(int tuneIndex, string addOn)
    {
        foreach (var id in this.Garage.ParkedCars)
        {
            var parkedCar = this.Cars[id];
            parkedCar.TuneUp(tuneIndex, addOn);
        }
    }

}


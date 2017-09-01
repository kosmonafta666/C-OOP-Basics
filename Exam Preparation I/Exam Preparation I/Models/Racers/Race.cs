using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Race
{
    private int length;
    private string route;
    private int prizePool;
    private Dictionary<int, Car> participants;


    public int Length
    {
        get { return this.length; }
        set
        {
            this.length = value;
        }
    }

    public string Route
    {
        get { return this.route; }
        set
        {
            this.route = value;
        }
    }

    public int PrizePool
    {
        get { return this.prizePool; }
        set
        {
            this.prizePool = value;
        }
    }

    public Dictionary<int, Car> Participants
    {
        get { return this.participants; }
        set
        {
            this.participants = value;
        }
    }
    public List<Car> Winners { get; set; }


    public Race(int length, string route, int prizePool)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prizePool;
        this.Participants = new Dictionary<int, Car>();
        this.Winners = new List<Car>();
    }

    public abstract int GetPerformance(int id);

    public List<int> GetPrizes()
    {
        var result = new List<int>();

        result.Add((this.PrizePool * 50) / 100);
        result.Add((this.PrizePool * 30) / 100);
        result.Add((this.PrizePool * 20) / 100);

        return result;
    }
 
    public Dictionary<int, Car> GetWinners()
    {
        var winners = this.Participants
            .OrderByDescending(x => this.GetPerformance(x.Key))
            .Take(3)
            .ToDictionary(x => x.Key, x => x.Value);

        return winners;
    }

    public string StartRace()
    {       

        var winners = GetWinners();
        var prizes = GetPrizes();

        var result = new StringBuilder();

        result.AppendLine($"{this.Route} - {this.Length}");

        for (int i = 0; i < winners.Count; i++)
        {
            var car = winners.ElementAt(i);

            result.AppendLine($"{i + 1}. {car.Value.Brand} {car.Value.Model} {GetPerformance(car.Key)}PP - ${prizes[i]}");
        }

        return result.ToString().Trim();
    }

    public override string ToString()
    {
        var result = new StringBuilder();

        result.AppendLine($"{this.Route} - {this.Length}");

        return result.ToString().Trim();
    }
}


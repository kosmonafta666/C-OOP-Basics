using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    private List<Nation> nations;
    private List<string> wars;

    protected List<Nation> Nations
    {
        get { return this.nations; }
        set { this.nations = value; }
    }

    protected List<string> Wars
    {
        get { return this.wars; }
        set { this.wars = value; }
    }

    public NationsBuilder()
    {
        this.Nations = new List<Nation>();
        this.Nations.Add(new Nation("Air"));
        this.Nations.Add(new Nation("Fire"));
        this.Nations.Add(new Nation("Earth"));
        this.Nations.Add(new Nation("Water"));

        this.Wars = new List<string>();
    }

    //create bendern and add it to appropiate nation;
    public void AssignBender(List<string> benderArgs)
    {
        //var for type of the bender;
        var type = benderArgs[0];
        //var for name of the bender;
        var name = benderArgs[1];
        //var for power of the bender;
        var power = int.Parse(benderArgs[2]);
        //var for secondary paprameter;
        var secondaryParam = float.Parse(benderArgs[3]);

        switch (type)
        {
            case "Air":
                var airNation = this.Nations.Where(x => x.Name == type).FirstOrDefault();
                airNation.Benders.Add(new AirBender(name, power, secondaryParam));              
                break;

            case "Fire":
                var fireNation = this.Nations.Where(x => x.Name == type).FirstOrDefault();
                fireNation.Benders.Add(new FireBender(name, power, secondaryParam));
                break;

            case "Earth":
                var earthNation = this.Nations.Where(x => x.Name == type).FirstOrDefault();
                earthNation.Benders.Add(new EarthBender(name, power, secondaryParam));
                break;
                
            case "Water":
                var waterNation = this.Nations.Where(x => x.Name == type).FirstOrDefault();
                waterNation.Benders.Add(new WaterBender(name, power, secondaryParam));
                break;
            default:
                break;
        }       
    }

    //create monument and add it to appropiate nation;
    public void AssignMonument(List<string> monumentArgs)
    {
        //var for type of the monument;
        var type = monumentArgs[0];
        //var for name of the monument;
        var name = monumentArgs[1];
        //var for afinity of the monument;
        var afinity = int.Parse(monumentArgs[2]);

        switch (type)
        {
            case "Air":
                var airNation = this.Nations.Where(x => x.Name == type).FirstOrDefault();
                airNation.Monuments.Add(new AirMonument(name, afinity));
                break;

            case "Fire":
                var fireNation = this.Nations.Where(x => x.Name == type).FirstOrDefault();
                fireNation.Monuments.Add(new FireMonument(name, afinity));
                break;

            case "Earth":
                var earthNation = this.Nations.Where(x => x.Name == type).FirstOrDefault();
                earthNation.Monuments.Add(new EarthMonument(name, afinity));
                break;

            case "Water":
                var waterNation = this.Nations.Where(x => x.Name == type).FirstOrDefault();
                waterNation.Monuments.Add(new WaterMonument(name, afinity));
                break;
            default:
                break;
        }      
    }

    //return string for given nation;
    public string GetStatus(string nationsType)
    {
        //nation to print details;
        var nation = this.Nations
            .Where(x => x.Name == nationsType)
            .FirstOrDefault();

        return nation.ToString(); 
    }

    //get war from given nation;
    public void IssueWar(string nationsType)
    {
        //nation to add in war list;
        var nation = this.Nations
           .Where(x => x.Name == nationsType)
           .FirstOrDefault();

        //winner nation;
        var winnerNation = this.Nations
            .OrderByDescending(x => x.GetPowerNation())
            .FirstOrDefault();

        //new list with losser nation;
        var loserNation = this.Nations
            .Where(x => x != winnerNation)
            .ToList();

        //clear the loser nation;
        foreach (var loser in loserNation)
        {
            loser.Clear();
        }

        //add nation to war list;
        this.Wars.Add(nationsType);
    }

    //return record of all wars;
    public string GetWarsRecord()
    {
        var result = new StringBuilder();
        var countWar = 1;

        foreach (var str in this.Wars)
        {
            result.AppendLine($"War {countWar} issued by {str}");
            countWar++;
        }

        return result.ToString().Trim(); 
    }

}


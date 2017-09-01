using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Nation
{
    private string name;
    private List<Bender> benders;
    private List<Monument> monuments;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public List<Bender> Benders
    {
        get { return this.benders; }
        set { this.benders = value; }
    }

    public List<Monument> Monuments
    {
        get { return this.monuments; }
        set { this.monuments = value; }
    }

    public Nation(string name)
    {
        this.Name = name;
        this.Benders = new List<Bender>();
        this.Monuments = new List<Monument>();
    }

    public void Clear()
    {
        this.Benders.Clear();
        this.Monuments.Clear();
    }

    public float GetPowerNation()
    {
        float totalPower = 0;

        var powerBenders = this.Benders.Sum(x => x.GetTotalPower());

        int monumentsPower = 0;

        if (this.Monuments.Count > 0)
        {
            monumentsPower = this.Monuments.Sum(x => x.GetAfinity());
        }

        if (monumentsPower > 0)
        {
            totalPower = (powerBenders / 100) * monumentsPower;
        }
        else
        {
            totalPower = powerBenders;
        }

        return totalPower;
    }

    public override string ToString()
    {
        var result = new StringBuilder();

        result.AppendLine($"{this.Name} Nation");

        if (this.Benders.Count == 0)
        {
            result.AppendLine("Benders: None");
        }
        else
        {
            result.AppendLine("Benders:");

            foreach (var bender in this.Benders)
            {
                result.AppendLine($"###{bender.ToString()}");
            }
        }

        if (this.Monuments.Count == 0)
        {
            result.AppendLine("Monuments: None");
        }
        else
        {
            result.AppendLine("Monuments:");

            foreach (var monument in this.Monuments)
            {
                result.AppendLine($"###{monument.ToString()}");
            }
        }

        return result.ToString().Trim();
    }
}

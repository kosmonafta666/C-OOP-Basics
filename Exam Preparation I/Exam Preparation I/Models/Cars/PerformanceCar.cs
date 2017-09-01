using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PerformanceCar : Car
{
    private List<string> addOns;

    public List<string> AddOns
    {
        get { return this.addOns; }

        set
        {
            this.addOns = value;
        }
    }

    public PerformanceCar(string brand, string model, int yearOfProduction,
        int horsePower, int acceleration, int suspension, int durabilty)
        :base(brand, model, yearOfProduction, horsePower, acceleration, suspension, durabilty)
    {
        this.AddOns = new List<string>();
        this.HorsePower += (base.HorsePower * 50) / 100;
        this.Suspension -= (base.Suspension * 25) / 100;
    }

    public override void TuneUp(int tuneIndex, string addOn)
    {
        base.TuneUp(tuneIndex, addOn);
        this.AddOns.Add(addOn);
    }

    public override string ToString()
    {
        var result = new StringBuilder(base.ToString());

        result.AppendLine($"Add-ons: {(this.AddOns.Any() ? $"{string.Join(", ", this.AddOns)}" : "None")}");

        return result.ToString().Trim();
    }
}


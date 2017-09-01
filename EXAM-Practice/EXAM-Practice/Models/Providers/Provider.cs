using System;

public abstract class Provider
{
    private string id;
    private double energyOutput;

    public string Id
    {
        get { return this.id; }
        protected set
        {
            this.id = value;
        }
    }

    public double EnergyOutput
    {
        get { return this.energyOutput; }
        protected set
        {
            this.energyOutput = value;
        }
    }

    protected Provider(string id, double energyOutput)
    {
        this.Id = id;
        this.EnergyOutput = energyOutput;
    }
}


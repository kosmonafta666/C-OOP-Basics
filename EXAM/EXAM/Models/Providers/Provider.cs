using System;

public abstract class Provider
{
    //private string id;
    private float energyOutput;

    public string Id { get; set; }
    


    public float EnergyOutput
    {
        get { return this.energyOutput; }
        protected set
        {
            if (value < 0 || value > 10000)
            {
                throw new ArgumentException($"Provider is not registered, because of it's {nameof(this.EnergyOutput)}");
            }

            this.energyOutput = value;
        }
    }

    public Provider(string id, float energyOutput)
    {
        this.Id = id;
        this.EnergyOutput = energyOutput;
    }

    
    public override string ToString()
    {
        return base.ToString();
    }
}


using System;

public class FireBender : Bender
{
    private float heatAggression;

    protected float HeatAggression
    {
        get { return this.heatAggression; }
        set { this.heatAggression = value; }
    }

    public FireBender(string name, int power, float heatAggression)
        :base(name, power)
    {
        this.HeatAggression = heatAggression;
    }

    public override float GetTotalPower()
    {
        return this.Power * this.HeatAggression;
    }

    public override string ToString()
    {
        return $"Fire Bender: {this.Name}, Power: {this.Power}, Heat Aggression: {this.HeatAggression:f2}";
    }
}


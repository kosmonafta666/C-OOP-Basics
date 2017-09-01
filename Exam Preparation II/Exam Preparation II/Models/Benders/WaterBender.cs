using System;

public class WaterBender :Bender
{
    private float waterClarity;

    protected float WaterClarity
    {
        get { return this.waterClarity; }
        set { this.waterClarity = value; }
    }

    public WaterBender(string name, int power, float waterClarity)
        :base(name, power)
    {
        this.WaterClarity = waterClarity;
    }

    public override float GetTotalPower()
    {
        return this.Power * this.WaterClarity;
    }

    public override string ToString()
    {
        return $"Water Bender: {this.Name}, Power: {this.Power}, Water Clarity: {this.WaterClarity:f2}";
    }
}


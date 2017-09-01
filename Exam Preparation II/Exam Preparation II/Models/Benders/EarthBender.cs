using System;

public class EarthBender : Bender
{
    private float groundSaturation;

    protected float GroundSaturation
    {
        get { return this.groundSaturation; }
        set { this.groundSaturation = value; }
    }

    public EarthBender(string name, int power, float groundSaturation)
        :base (name, power)
    {
        this.GroundSaturation = groundSaturation;
    }

    public override float GetTotalPower()
    {
        return this.Power * this.GroundSaturation;
    }

    public override string ToString()
    {
        return $"Earth Bender: {this.Name}, Power: {this.Power}, Ground Saturation: {this.GroundSaturation:f2}";
    }
}


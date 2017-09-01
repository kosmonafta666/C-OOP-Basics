using System;

public class AirBender : Bender
{ 
    private float aerialIntegrity;

    protected float AerialIntegrity
    {
        get { return this.aerialIntegrity; }
        set { this.aerialIntegrity = value; }
    }

    public AirBender(string name, int power, float aerialIntegrity)
        :base (name, power)
    {
        this.AerialIntegrity = aerialIntegrity;
    }

    public override float GetTotalPower()
    {
        return this.Power * this.AerialIntegrity;
    }

    public override string ToString()
    {
        return $"Air Bender: {this.Name}, Power: {this.Power}, Aerial Integrity: {this.AerialIntegrity:f2}";
    }
}


using System;

public class AirMonument : Monument
{
    private int airAffinity;

    protected int AirAffinity
    {
        get { return this.airAffinity; }
        set { this.airAffinity = value; }
    }

    public AirMonument(string name, int airAffinity)
        :base(name)
    {
        this.AirAffinity = airAffinity;
    }

    public override string ToString()
    {
        return $"Air Monument: {this.Name}, Air Affinity: {this.AirAffinity}";
    }

    public override int GetAfinity()
    {
        return this.AirAffinity;
    }
}


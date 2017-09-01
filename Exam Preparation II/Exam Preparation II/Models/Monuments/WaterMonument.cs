using System;

public class WaterMonument : Monument
{
    private int waterAffinity;

    protected int WaterAffinity
    {
        get { return this.waterAffinity; }
        set { this.waterAffinity = value; }
    }

    public WaterMonument(string name, int waterAffinity)
        :base(name)
    {
        this.WaterAffinity = waterAffinity;
    }

    public override string ToString()
    {
        return $"Water Monument: {this.Name}, Water Affinity: {this.WaterAffinity}";
    }

    public override int GetAfinity()
    {
        return this.WaterAffinity;
    }
}


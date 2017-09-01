using System;

public class EarthMonument : Monument
{
    private int earthAffinity;

    protected int EarthAffinity
    {
        get { return this.earthAffinity; }
        set { this.earthAffinity = value; }
    }

    public EarthMonument(string name, int earthAffinity)
        :base (name)
    {
        this.EarthAffinity = earthAffinity;
    }

    public override string ToString()
    {
        return $"Earth Monument: {this.Name}, Earth Affinity: {this.EarthAffinity}";
    }

    public override int GetAfinity()
    {
        return this.EarthAffinity;
    }
}


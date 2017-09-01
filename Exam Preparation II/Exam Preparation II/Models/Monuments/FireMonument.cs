using System;

public class FireMonument : Monument
{
    private int fireAffinity;

    protected int FireAffinity
    {
        get { return this.fireAffinity; }
        set { this.fireAffinity = value; }
    }

    public FireMonument(string name, int fireAffinity)
        :base(name)
    {
        this.FireAffinity = fireAffinity;
    }

    public override string ToString()
    {
        return $"Fire Monument: {this.Name}, Fire Affinity: {this.FireAffinity}";
    }

    public override int GetAfinity()
    {
        return this.FireAffinity;
    }
}


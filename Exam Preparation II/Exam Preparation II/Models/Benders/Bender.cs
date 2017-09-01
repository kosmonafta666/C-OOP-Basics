using System;

public abstract class Bender
{
    private string name;
    private int power;

    protected string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    protected int Power
    {
        get { return this.power; }
        set { this.power = value; }
    }

    protected Bender(string name, int power)
    {
        this.Name = name;
        this.Power = power;
    }

    public abstract float GetTotalPower(); 
}


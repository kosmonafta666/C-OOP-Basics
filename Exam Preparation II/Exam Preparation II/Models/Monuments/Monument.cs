using System;

public abstract class Monument
{
    private string name;

    protected string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    protected Monument(string name)
    {
        this.Name = name;
    }

    public abstract int GetAfinity();
}


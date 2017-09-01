using System;
using System.Collections;

public class RandomList : ArrayList
{
    private Random rnd;
    private ArrayList data;

    public ArrayList Data
    {
        get { return this.data; }
        set { this.data = value; }
    }

    public RandomList()
    {
        this.rnd = new Random();

        this.Data = new ArrayList();
    }

    public string RandomString()
    {
        int index = rnd.Next(0, data.Count - 1);

        var str = data[index];

        data.Remove(str);

        return str.ToString();
    }
}


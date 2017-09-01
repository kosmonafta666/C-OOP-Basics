using System;
using System.Collections.Generic;

public class Garage
{
    private List<int> parkedCars;

    public List<int> ParkedCars
    {
        get { return this.parkedCars; }
        set
        {
            this.parkedCars = value;
        }
    }

    public Garage()
    {
        this.ParkedCars = new List<int>();
    }

    public void AddCar(int id)
    {
        this.ParkedCars.Add(id);
    }

    public void RemoveCar(int id)
    {
        this.ParkedCars.Remove(id);
    }
}


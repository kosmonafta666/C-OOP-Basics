using System;
using System.Text;

public class ShowCar : Car
{
    private int stars;

    public int Stars
    {
        get { return this.stars; }
        set
        {
            this.stars = value;
        }
    }

    public ShowCar(string brand, string model, int yearOfProduction,
        int horsePower, int acceleration, int suspension, int durabilty)
        :base(brand, model, yearOfProduction, horsePower, acceleration, suspension, durabilty)
    {
        this.Stars = 0;
    }

    public override void TuneUp(int tuneIndex, string addOn)
    {
        base.TuneUp(tuneIndex, addOn);
        this.Stars += tuneIndex;
    }

    public override string ToString()
    {
        var result = new StringBuilder(base.ToString());

        result.AppendLine($"{this.Stars} *");

        return result.ToString().Trim();
    }
}


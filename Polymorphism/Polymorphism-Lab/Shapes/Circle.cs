using System;

public class Circle : Shape
{
    private double radius;

    public double Radius
    {
        get { return this.radius; }

        private set
        {
            this.radius = value;
        }
    }

    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * this.radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(this.radius, 2);
    }

    public override string Draw()
    {
        return base.Draw() + "Circle";
    }
}


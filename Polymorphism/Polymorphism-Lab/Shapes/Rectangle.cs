using System;

public class Rectangle : Shape
{
    private double width;
    private double height;

    public double Width
    {
        get { return this.width; }

        set
        {
            this.width = value;
        }
    }

    public double Height
    {
        get { return this.height; }

        set
        {
            this.height = value;
        }
    }

    public Rectangle(double width, double height)
    {
        this.Width = width;

        this.Height = height;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (this.width + this.height);
    }

    public override double CalculateArea()
    {
        return this.width * this.height;
    }

    public override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}


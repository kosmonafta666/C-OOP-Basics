﻿public class Box
{
    private double length;

    private double width;

    private double height;


    public double Length
    {
        get { return this.length; }

        private set { this.length = value; }
    }

    public double Width
    {
        get { return this.width; }

        private set { this.width = value; }
    }

    public double Height
    {
        get { return this.height; }

        private set { this.height = value; }
    }

    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    public double SurfaceArea()
    {
        var area = (2 * this.Length * this.Width) +
            (2 * this.Length * this.Height) +
            (2 * this.Width * this.Height);

        return area;
    }

    public double LateralSurfaceArea()
    {
        var area = (2 * this.Length * this.Height) + (2 * this.Width * this.Height);

        return area;
    }

    public double Volume()
    {
        var volume = this.Length * this.Width * this.Height;

        return volume;
    }
}
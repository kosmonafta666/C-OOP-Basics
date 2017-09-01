namespace Class_Box_Data_Validation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Box
    {
        private double length;

        private double width;

        private double height;

        public double Length
        {
            get
            {
                return this.length;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Length)} cannot be zero or negative.");
                }

                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Width)} cannot be zero or negative.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Height)} cannot be zero or negative.");
                }

                this.height = value;
            }
        }

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double SurfaceArea()
        {
            var area = (2 * this.length * this.width) +
                (2 * this.length * this.height) +
                (2 * this.width * this.height);

            return area;
        }

        public double LateralSurfaceArea()
        {
            var area = (2 * this.length * this.height) + (2 * this.width * this.height);

            return area;
        }

        public double Volume()
        {
            var volume = this.length * this.width * this.height;

            return volume;
        }
    }
}

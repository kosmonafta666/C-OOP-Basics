namespace Rectangle_Intersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Rectangle
    {
        private string id;

        private double width;

        private double height;

        private double x;

        private double y;

        public string ID
        {
            get { return this.id; }

            set { this.id = value; }
        }

        public double Width
        {
            get { return this.width; }

            set { this.width = value; }
        }

        public double Height
        {
            get { return this.height; }

            set { this.height = value; }
        }

        public double X
        {
            get { return this.x; }

            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }

            set { this.y = value; }
        }

        public Rectangle (string id, double width, double height, double x, double y)
        {
            this.ID = id;

            this.Width = width;

            this.Height = height;

            this.X = x;

            this.Y = y;
        }

        public bool IsIntersect(Rectangle rect)
        {
            bool flag = false;

            var x11 = this.X;
            var y11 = this.Y;

            var x21 = rect.X;
            var y21 = rect.Y;
    

            if (Math.Abs(x11) < Math.Abs(x21 + rect.Width))
            {
                if (Math.Abs(x11 + this.Width) >= Math.Abs(x21) )
                {
                    if (y11 < Math.Abs(y21 - rect.height))
                    {
                        if (Math.Abs(y11 + this.Height) >= Math.Abs(y21))
                        {
                            flag = true;
                        }
                    }
                }
            }

            return flag;
        }
    }
}

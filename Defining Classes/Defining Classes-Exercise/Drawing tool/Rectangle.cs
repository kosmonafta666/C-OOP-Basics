namespace Drawing_tool
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Rectangle
    {
        private int width;
        private int height;

        public int Width
        {
            get { return this.width; }

            private set { this.width = value; }
        }

        public int Height
        {
            get { return this.height; }

            private set { this.height = value; }
        }

        public Rectangle(int width, int height)
        {
            this.Width = width;

            this.Height = height;
        }

        public void Draw()
        {
            var firstRow = new string('-', this.width);
            var innerRow = new string(' ', this.width);

            Console.WriteLine($"|{firstRow}|");

            for (int i = 0; i < this.height - 2; i++)
            {
                Console.WriteLine($"|{innerRow}|");
            }

            Console.WriteLine($"|{firstRow}|");
        }
     }
}

namespace Drawing_tool
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Square
    {
        private int size;

        public int Size
        {
            get { return this.size; }

            private set { this.size = value; }
        }

        public Square(int size)
        {
            this.Size = size;
        }

        public void Draw()
        {
            var firstRow = new string('-', this.size);
            var innerRow = new string(' ', this.size);

            Console.WriteLine($"|{firstRow}|");
            
            for (int i = 0; i < this.size - 2; i++)
            {
                Console.WriteLine($"|{innerRow}|");
            }

            Console.WriteLine($"|{firstRow}|");
        }
    }
}

namespace Drawing_tool
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Shape
    {
        abstract public void Draw();
    }

    public class Square : Shape
    {
        public int side;

        public Square(int side)
        {
            this.side = side;
        }

        public override void Draw()
        {
            Console.WriteLine("{0}{1}{0}", "|", new string('-', this.side));

            for (int i = 0; i < this.side - 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", "|", new string(' ', this.side));
            }

            Console.WriteLine("{0}{1}{0}", "|", new string('-', this.side));
        }
    }

    public class Rectangle : Shape
    {
        public int length;

        public int width;

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public override void Draw()
        {
            Console.WriteLine("{0}{1}{0}", "|", new string('-', this.width));

            for (int i = 0; i < this.length - 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", "|", new string(' ', this.width));
            }

            Console.WriteLine("{0}{1}{0}", "|", new string('-', this.width));
        }
    }

    public class CorDraw
    {
        public CorDraw(Shape shape)
        {
            this.Draw(shape);
        }

        public void Draw(Shape shape)
        {
            shape.Draw();
        }
    }

    public class DrawingTool
    {
        public static void Main(string[] args)
        {
            //read the type of shape;
            var typeOfShape = Console.ReadLine();

            Shape shape = null;

            if (typeOfShape == "Square")
            {
                //read the side;
                var side = int.Parse(Console.ReadLine());

                var square = new Square(side);
                shape = square;
                var figure = new CorDraw(shape);
            }
            else if (typeOfShape == "Rectangle")
            {
                //read the width;
                var width = int.Parse(Console.ReadLine());
                //read the length;
                var length = int.Parse(Console.ReadLine());

                var rectangle = new Rectangle(length, width);
                shape = rectangle;
                var figure = new CorDraw(shape);
            }
        }
    }
}

namespace Drawing_tool
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DrawingTool
    {
        public static void Main(string[] args)
        {
            //read the shape;
            var shape = Console.ReadLine();

            if (shape == "Square")
            {
                //read the size of the square;
                var size = int.Parse(Console.ReadLine());

                //create new square and draw it;
                var square = new Square(size);

                square.Draw();
            }
            else if (shape == "Rectangle")
            {
                //read the width;
                var width = int.Parse(Console.ReadLine());
                //read the height;
                var height = int.Parse(Console.ReadLine());

                //create the rectangle and draw it;
                var rectangle = new Rectangle(width, height);

                rectangle.Draw();
            }
        }
    }
}

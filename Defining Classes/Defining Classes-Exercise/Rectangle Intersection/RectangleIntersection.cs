namespace Rectangle_Intersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class RectangleIntersection
    {
        static void Main(string[] args)
        {
            //read the number of rectangles and intesection checks;
            var inputStr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var numberOfRect = inputStr[0];

            var intersectChecks = inputStr[1];

            //list for all rectangles;
            var rectangles = new List<Rectangle>();

            //read the rectangles;
            for (int i = 1; i <= numberOfRect; i++)
            {
                //read the current command and splitted;
                var command = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                //var for ID;
                var id = command[0];
                //var for width;
                var width = double.Parse(command[1]);
                //var for height;
                var height = double.Parse(command[2]);
                //var for X;
                var x = double.Parse(command[3]);
                //var for Y;
                var y = double.Parse(command[4]);

                //create rectangle and add it to list;
                var currentRect = new Rectangle(id, width, height, x, y);

                rectangles.Add(currentRect);
            }//end of reading the rectangles;

            //reading the intersection commands;
            for (int i = 1; i <= intersectChecks; i++)
            {
                //read the command and splitted;
                var command = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                //var for first rectangle;
                var firstRect = rectangles
                    .Where(x => x.ID == command[0])
                    .FirstOrDefault();

                //var for first rectangle;
                var secondRect = rectangles
                    .Where(x => x.ID == command[1])
                    .FirstOrDefault();               

                if (firstRect != null && secondRect != null)
                {
                    //check for intersect and print it;
                    var isIntersect = firstRect.IsIntersect(secondRect);

                    if (isIntersect)
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }               
            }
        }
    }
}

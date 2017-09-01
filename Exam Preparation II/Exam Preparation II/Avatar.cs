namespace Exam_Preparation_II
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Avatar
    {
        public static void Main(string[] args)
        {
            NationsBuilder nationBuilder = new NationsBuilder();

            string input;

            while ((input = Console.ReadLine()) != "Quit")
            {
                //var for splited input;
                var tokens = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                switch (tokens[0])
                {
                    case "Bender":
                        //list for bender commands;
                        var benderArgs = tokens.Skip(1).ToList();
                        nationBuilder.AssignBender(benderArgs);
                        break;
                    case "Monument":
                        //list for bender commands;
                        var monumentsArgs = tokens.Skip(1).ToList();
                        nationBuilder.AssignMonument(monumentsArgs);
                        break;
                    case "Status":
                        Console.WriteLine(nationBuilder.GetStatus(tokens[1]));
                        break;
                    case "War":
                        nationBuilder.IssueWar(tokens[1]);
                        break;
                }
            }//end of while loop;

            Console.WriteLine(nationBuilder.GetWarsRecord());
        }
    }
}

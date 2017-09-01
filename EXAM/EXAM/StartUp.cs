namespace EXAM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var manager = new DraftManager();

            string input;

            while ((input = Console.ReadLine()) != "Shutdown")
            {
                var tokens = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var cmdAgrs = tokens.Skip(1).ToList();

                switch (tokens[0])
                {
                    case "RegisterHarvester":
                        Console.WriteLine(manager.RegisterHarvester(cmdAgrs));
                        break;
                    case "RegisterProvider":
                        Console.WriteLine(manager.RegisterProvider(cmdAgrs));
                        break;
                    case "Check":
                        Console.WriteLine(manager.Check(cmdAgrs));
                        break;
                }
            }
        }
    }
}

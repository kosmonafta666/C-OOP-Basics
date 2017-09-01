namespace Encapsulation_Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main()
        {

            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            Team teams = new Team("Dfififi");

            for (int i = 0; i < lines; i++)
            {              
                try
                {
                    var cmdArgs = Console.ReadLine().Split();
                    var person = new Person(cmdArgs[0],
                                            cmdArgs[1],
                                            int.Parse(cmdArgs[2]),
                                            double.Parse(cmdArgs[3]));

                    persons.Add(person);                  

                    teams.AddPlayer(person);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }             
            }

            //var bonus = double.Parse(Console.ReadLine());
            //persons.ForEach(x => x.IncreaseSalary(bonus));
            //persons.ForEach(x => Console.WriteLine(x.ToString()));


            Console.WriteLine("First team have {0} players", teams.FirstTeam.Count);

            Console.WriteLine("Reserve team have {0} players", teams.ReserveTeam.Count);
        }
    }
}

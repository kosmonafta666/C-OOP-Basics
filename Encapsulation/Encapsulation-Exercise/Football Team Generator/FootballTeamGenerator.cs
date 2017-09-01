namespace Football_Team_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FootballTeamGenerator
    {
        static Dictionary<string, Team> teams = new Dictionary<string, Team>();

        public static void Main(string[] args)
        {
            //read the input line;
            var line = Console.ReadLine();

            while (line != "END")
            {
                //var for splitted line;
                var tokens = line
                    .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                //var for command;
                var cmd = tokens[0];

                try
                {
                    ProcessComand(tokens, cmd);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }

                line = Console.ReadLine();
            }
        }

        private static void ProcessComand(string[] tokens, string cmd)
        {
            switch (cmd)
            {
                case "Team":
                    CreateTeam(tokens[1]);
                    break;
                case "Add":
                    AddPlayerToTeam(
                        tokens[1],
                        tokens[2],
                        int.Parse(tokens[3]),
                        int.Parse(tokens[4]),
                        int.Parse(tokens[5]),
                        int.Parse(tokens[6]),
                        int.Parse(tokens[7])
                        );
                    break;
                case "Remove":
                    RemovePlayerToTeam(tokens[1], tokens[2]);
                    break;
                case "Rating":
                    GetRating(tokens[1]);
                    break;
                default:
                    break;
            }
        }

        private static void GetRating(string teamName)
        {
            if (!teams.ContainsKey(teamName))
            {
                throw new InvalidOperationException($"Team {teamName} does not exist.");
            }

            Team team = teams[teamName];

            Console.WriteLine(team);
        }

        private static void RemovePlayerToTeam(string teamName, string playerName)
        {
            if (!teams.ContainsKey(teamName))
            {
                throw new InvalidOperationException($"Team {teamName} does not exist.");
            }

            Team team = teams[teamName];
            team.RemovePlayer(playerName);
        }

        private static void AddPlayerToTeam(string teamName, 
            string playerName, int endurance, 
            int sprint, int dribble, 
            int passing, int shooting)
        {
            if (!teams.ContainsKey(teamName))
            {
                throw new InvalidOperationException($"Team {teamName} does not exist.");             
            }

            var player = new Player(playerName,
                new Stat("Endurance", endurance),
                new Stat("Sprint", sprint),
                new Stat("Dribble", dribble),
                new Stat("Passing", passing),
                new Stat("Shooting", shooting)
                );

            Team team = teams[teamName];
            team.AddPlayer(player);
        }

        private static void CreateTeam(string name)
        {
            var team = new Team(name);
            teams.Add(name, team);
        }
    }
}

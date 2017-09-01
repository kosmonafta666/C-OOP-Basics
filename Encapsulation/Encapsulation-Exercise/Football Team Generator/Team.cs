namespace Football_Team_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Team
    {
        private string name;

        private double rating;

        private Dictionary<string, Player> players;

        public string Name
        {
            get { return this.name; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"A {nameof(this.name)} should not be empty.");
                }

                this.name = value;
            }
        }

        public Team(string name)
        {
            this.Name = name;
            this.players = new Dictionary<string, Player>();
            this.rating = 0.0;
        }

        public void AddPlayer(Player player)
        {
            this.rating += player.OverallSkills;
            players.Add(player.Name, player);
        }

        public void RemovePlayer(string playerName)
        {
            if (!this.players.ContainsKey(playerName))
            {
                throw new InvalidOperationException($"Player {playerName} is not in {this.Name} team.");
            }

            Player player = this.players[playerName];

            this.rating -= player.OverallSkills;
            this.players.Remove(player.Name);
        }

        public override string ToString()
        {
            var result = $"{this.Name} - {this.rating}";

            return result;
        }
    }
}

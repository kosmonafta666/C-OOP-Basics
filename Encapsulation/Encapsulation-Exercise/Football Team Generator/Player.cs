namespace Football_Team_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Player
    {
        private string name;

        public Stat Endurance { get; }
        public Stat Sprint { get; }
        public Stat Dribble { get; }
        public Stat Passing { get; }
        public Stat Shooting { get; }

        private double overallSkills;

        public double OverallSkills
        {
            get { return this.overallSkills; }

            private set { this.overallSkills = value; }
        }

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

        public Player(string name, Stat endurance, Stat sprint, Stat dribble, Stat passing, Stat shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;

            CalculateAverageStat();
        }

        private void CalculateAverageStat()
        {
            double sum = (this.Endurance.Level + this.Sprint.Level +
                this.Dribble.Level + this.Passing.Level + this.Shooting.Level);

            this.OverallSkills = Math.Round(sum / 5, 0);
        }
    }
}

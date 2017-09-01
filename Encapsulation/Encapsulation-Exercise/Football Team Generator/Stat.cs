namespace Football_Team_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Stat
    {
        private const int LevelMin = 0;

        private const int LevelMax = 100;

        private string name;

        private int level;

        public string Name
        {
            get { return this.name; }

            set { this.name = value; }
        }

        public int Level
        {
            get { return this.level; }

            set
            {
                if (value < LevelMin || value > LevelMax)
                {
                    throw new ArgumentException($"{this.Name} should be between {LevelMin} and {LevelMax}.");
                }

                this.level = value;
            }
        }

        public Stat(string name, int level)
        {
            this.Name = name;
            this.Level = level;
        }
    }
}

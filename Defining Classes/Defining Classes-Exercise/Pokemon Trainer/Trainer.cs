namespace Pokemon_Trainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Trainer
    {
        private string name;

        private int badges;

        private List<Pokemon> pokemons;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Badges
        {
            get { return this.badges; }
            set { this.badges = value; }
        }

        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
            set { this.pokemons = value; }
        }

        public Trainer(string name)
        {
            this.Name = name;
            this.Badges = 0;
            this.Pokemons = new List<Pokemon>();
        }

        public bool ContainTypeOfPokemon(string type)
        {
            bool flag = false;

            foreach (var pokemon in this.Pokemons)
            {
                if (pokemon.Element == type)
                {
                    flag = true;
                }
            }

            return flag;
        }

        public void DecreaseHealth()
        {
            for (int i = 0; i < this.Pokemons.Count; i++)
            {
                this.Pokemons[i].Health -= 10;
            }
        }

        public void RemoveDeadPokemons()
        {
            this.Pokemons = this.Pokemons
                .Where(x => x.Health > 0)
                .ToList();
        }
    }
}

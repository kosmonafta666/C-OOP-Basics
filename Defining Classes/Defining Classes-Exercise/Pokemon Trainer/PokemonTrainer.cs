namespace Pokemon_Trainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PokemonTrainer
    {
        public static void Main(string[] args)
        {
            //list for pokemon trainers;
            var pokemonTrainers = new List<Trainer>();

            //read the trainers and pokemons;
            var command1 = "";

            while((command1 = Console.ReadLine()) != "Tournament")
            {
                //var for splitted command1;
                var token = command1
                    .Split(' ')
                    .ToArray();

                //var for trainer name;
                var trainerName = token[0];
                //var for pokemon name;
                var pokemonName = token[1];
                //var for pokemon type;
                var pokemonType = token[2];
                //var for pokemon health;
                var pokemonHealth = int.Parse(token[3]);

                //bool to check if trainer already exist in trainers list;
                bool isExist = pokemonTrainers.Any(x => x.Name == trainerName);

                //if does not exist add to list with pokemon
                //else add pokemon to existing trainer;
                if (!isExist)
                {
                    //create new trainer;
                    var currentTrainer = new Trainer(trainerName);
                    //create new pokemon;
                    var currentPokemon = new Pokemon(pokemonName, pokemonType, pokemonHealth);
                    //add pokemon to current trainer;
                    currentTrainer.Pokemons.Add(currentPokemon);
                    //add current trainer to trainers list;
                    pokemonTrainers.Add(currentTrainer);
                }
                else
                {
                    //extract existing trainer from trainers list;
                    var currentTrainer = pokemonTrainers
                        .Where(x => x.Name == trainerName)
                        .FirstOrDefault();
                    //create new pokemon;
                    var currentPokemon = new Pokemon(pokemonName, pokemonType, pokemonHealth);
                    //add current pokemon to existing trainer;
                    currentTrainer.Pokemons.Add(currentPokemon);
                }
            }//end of reading command1;

            //read the command2;
            var command2 = "";

            while ((command2 = Console.ReadLine()) != "End")
            {
                //var for type to check;
                var type = command2;

                for (int i = 0; i < pokemonTrainers.Count; i++)
                {
                    //var for current trainer from the list;
                    var currentTrainer = pokemonTrainers[i];

                    //check for existing type of pokemons of 
                    //current trainer if not decrease health and remove dead pokemon;
                    if (currentTrainer.ContainTypeOfPokemon(type))
                    {
                        currentTrainer.Badges++;
                    }
                    else
                    {
                        currentTrainer.DecreaseHealth();
                        currentTrainer.RemoveDeadPokemons();
                    }
                }
            }


            //printing the result;
            foreach (var trainer in pokemonTrainers.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine("{0} {1} {2}", trainer.Name, trainer.Badges, trainer.Pokemons.Count);
            }
        }
    }
}

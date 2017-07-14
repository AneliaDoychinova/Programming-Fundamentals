using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Pokemon_Evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemons = new Dictionary<string, List<Pokemon>>();

            var input = Console.ReadLine();

            while (input != "wubbalubbadubdub")
            {
                var tokens = input.Split(new char[] { '-', ' ', '>' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 1)
                {
                    var wantedPokemon = tokens[0];

                    if (pokemons.ContainsKey(wantedPokemon))
                    {
                        PrintPokemonStats(wantedPokemon, pokemons);
                    }        
                }
                else
                {
                    var pokemonName = tokens[0];
                    var evolutionType = tokens[1];
                    var evolutionIndex = long.Parse(tokens[2]);

                    if (!pokemons.ContainsKey(pokemonName))
                    {
                        pokemons[pokemonName] = new List<Pokemon>();
                        
                    }

                    var pokemon = new Pokemon()
                    {
                        Name = pokemonName,
                        EvolutionType = evolutionType,
                        EvolutionIndex = evolutionIndex
                    };

                    pokemons[pokemonName].Add(pokemon);
     
                }

                input = Console.ReadLine();
            }

            PrintAllPokemons(pokemons);
        }

        private static void PrintAllPokemons(Dictionary<string, List<Pokemon>> pokemons)
        {
            foreach (var pokemon in pokemons)
            {
                Console.WriteLine("# {0}", pokemon.Key);

                foreach (var kvp in pokemon.Value.OrderByDescending(a => a.EvolutionIndex))
                {
                    Console.WriteLine("{0} <-> {1}", kvp.EvolutionType, kvp.EvolutionIndex);
                }
            }
        }

        private static void PrintPokemonStats(string wantedPokemon, Dictionary<string, List<Pokemon>> pokemons)
        {
            foreach (var pokemon in pokemons.Where(a => a.Key == wantedPokemon))
            {
                Console.WriteLine("# {0}", pokemon.Key);

                foreach (var kvp in pokemon.Value)
                {
                    Console.WriteLine("{0} <-> {1}", kvp.EvolutionType, kvp.EvolutionIndex);
                }
            }
        }

        class Pokemon
        {
            public string Name { get; set; }

            public string EvolutionType { get; set; }

            public long EvolutionIndex { get; set; }
        }
    }
}

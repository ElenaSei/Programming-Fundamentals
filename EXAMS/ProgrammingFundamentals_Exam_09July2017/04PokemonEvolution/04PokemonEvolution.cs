using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04PokemonEvolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> pokemons = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "wubbalubbadubdub")
            {
                string[] pokemon = input.Split(" -> ");

                string pokemonName = pokemon[0];

                if (pokemon.Length == 1)
                {
                    if (pokemons.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");

                        foreach (var item in pokemons[pokemonName])
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
                else
                {
                    string evolutionTypeIndex = pokemon[1] + " <-> " + pokemon[2];

                    if (!pokemons.ContainsKey(pokemonName))
                    {
                        pokemons.Add(pokemonName, new List<string>());
                    }

                    pokemons[pokemonName].Add(evolutionTypeIndex);
                }
            }


            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Key}");

                foreach (var type in pokemon.Value.OrderByDescending(i => int.Parse(i.Split(" <-> ")[1])))
                {
                    
                    Console.WriteLine(type);
                }
            }
        }
    }
}

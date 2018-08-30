namespace _04_PokemonЕvolution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PokemonЕvolution
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var pokemonEvolution = new Dictionary<string, List<KeyValuePair<string, int>>>();

            while (input[0] != "wubbalubbadubdub")
            {
                if (input.Length == 1)
                {
                    var pokemonName = input[0];

                    if (pokemonEvolution.ContainsKey(pokemonName))
                    {
                        Console.WriteLine("# {0}", pokemonName);
                        foreach (var kvp in pokemonEvolution[pokemonName])
                        {
                            Console.WriteLine("{0} <-> {1}", kvp.Key, kvp.Value);
                        }
                    }
                }

                else
                {
                    var pokemonName = input[0];
                    var evolutionType = input[1];
                    var evolutionIndex = int.Parse(input[2]);

                    if (!pokemonEvolution.ContainsKey(pokemonName))
                    {
                        pokemonEvolution.Add(pokemonName, new List<KeyValuePair<string, int>>());
                        pokemonEvolution[pokemonName].Add(new KeyValuePair<string, int>(evolutionType, evolutionIndex));
                    }

                    else
                    {
                        pokemonEvolution[pokemonName].Add(new KeyValuePair<string, int>(evolutionType, evolutionIndex));
                    }
                }

                input = Console.ReadLine()
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            foreach (var name in pokemonEvolution)
            {
                Console.WriteLine("# {0}", name.Key);
                foreach (var kvp in name.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("{0} <-> {1}", kvp.Key, kvp.Value);
                }
            }
        }
    }
}

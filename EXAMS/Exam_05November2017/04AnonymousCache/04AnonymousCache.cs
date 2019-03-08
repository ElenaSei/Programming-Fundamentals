using System;
using System.Collections.Generic;
using System.Linq;

namespace _04AnonymousCache
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> cache = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, long> setSize = new Dictionary<string, long>();
            Dictionary<string, List<string>> setKey = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine())!="thetinggoesskrra")
            {
                string[] tokens = input.Split(" ->|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string set = "";
                string key = "";
                int size = 0;

                if (tokens.Length == 1)
                {
                    set = tokens[0];

                    if (!setKey.ContainsKey(set))
                    {
                        setKey.Add(set, new List<string>());
                        setSize.Add(set, 0);
                        if (cache.ContainsKey(set))
                        {
                            foreach (var kvp in cache[set])
                            {
                                setSize[set] += kvp.Value;
                                setKey[set].Add(kvp.Key);
                            }
                        }
                    }
                }
                else
                {
                    set = tokens[2];
                    key = tokens[0];
                    size = int.Parse(tokens[1]);

                    if (setKey.ContainsKey(set))
                    {
                        setKey[set].Add(key);
                        setSize[set] += size;
                    }
                    else
                    {
                        if (!cache.ContainsKey(set))
                        {
                            cache.Add(set, new Dictionary<string, int>());
                        }
                        cache[set].Add(key, size);
                    }
                }
            }
            if (setSize.Count > 0)
            {
                var maxValue = setSize.OrderByDescending(x => x.Value).First();

                Console.WriteLine($"Data Set: {maxValue.Key}, Total Size: {maxValue.Value}");

                foreach (var item in setKey[maxValue.Key])
                {
                    Console.WriteLine($"$.{item}");
                }
            }
        }
    }
}

using System;

namespace _03KarateStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string punches = Console.ReadLine();
            int punchStrength = 0;
            string output = "";
            for (int i = 0; i < punches.Length; i++)
            {
                if (punches[i] == '>')
                {
                    punchStrength += int.Parse(punches[i + 1].ToString());
                    output += punches[i];
                    string removed = punches.Substring(i + 1, punchStrength);
                    for (int k = 0; k < removed.Length; k++)
                    {
                        i++;
                        if (removed[k] == '>')
                        {
                            output += removed[k];
                            punchStrength += int.Parse(punches[i + 1].ToString());
                        }
                        else
                        {
                            punchStrength -= 1;
                        }
                    }
                }
                else if (punchStrength != 0)
                {
                    punchStrength -= 1;
                }
                else
                {
                    output += punches[i];
                }
            }
            Console.WriteLine(output);
        }
    }
}

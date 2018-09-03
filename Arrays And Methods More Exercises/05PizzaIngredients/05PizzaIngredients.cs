using System;
using System.Linq;

namespace _05PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine()
                                          .Split(' ')
                                          .ToArray();
            int length = int.Parse(Console.ReadLine());
            int counter = 0;
            string[] pickedIngredients = new string[10];
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i].Length == length)
                {
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    pickedIngredients[counter] = ingredients[i];
                    counter++;
                    if (counter >= 10)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"Made pizza with total of {counter} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", pickedIngredients, 0, counter)}.");
        }
    }
}

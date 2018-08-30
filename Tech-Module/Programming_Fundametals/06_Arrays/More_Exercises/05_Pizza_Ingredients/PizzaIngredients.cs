namespace _05_Pizza_Ingredients
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class PizzaIngredients
    {
        public static void Main()
        {
            var array = Console.ReadLine()
                ?.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var maxLenght = int.Parse(Console.ReadLine());
            var ingredients = new List<string>();

            foreach (var ingr in array)
            {
                if (ingr.Length != maxLenght) continue;

                ingredients.Add(ingr);
                Console.WriteLine($"Adding {ingr}.");

                if (ingredients.Count >= 10)
                {
                    break;
                }
            }

            Console.Write($"Made pizza with total of {ingredients.Count} ingredients.\nThe ingredients are: ");
            Console.Write(string.Join(", ", ingredients));
            Console.WriteLine($".");
        }
    }
}

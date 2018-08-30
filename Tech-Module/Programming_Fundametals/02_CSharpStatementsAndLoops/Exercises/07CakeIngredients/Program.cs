using System;

public class CakeIngredients
{
    public static void Main()
    {
        var sum = 0.0;

        string ingredient;
        while ((ingredient = Console.ReadLine()) != "Bake!")
        {
            Console.WriteLine($"Adding ingredient {ingredient}.");
            sum++;
        }

        Console.WriteLine($"Preparing cake with {sum} ingredients.");
    }
}
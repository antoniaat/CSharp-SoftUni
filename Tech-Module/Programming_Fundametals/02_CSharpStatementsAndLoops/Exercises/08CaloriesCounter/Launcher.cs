using System;

public class Launcher
{
    public static double Calories;

    public static void Main()
    {
        var ingredientsCount = int.Parse(Console.ReadLine());

        for (int index = 0; index <= ingredientsCount; index++)
        {
            var ingredients = Console.ReadLine()?.ToLower();
            CalculateCalories(ingredients);
        }

        Console.WriteLine($"Total calories: {Calories}");
    }

    private static void CalculateCalories(string ingredients)
    {
        switch (ingredients)
        {
            case "cheese":
                Calories += 500;
                break;
            case "tomato sauce":
                Calories += 150;
                break;
            case "salami":
                Calories += 600;
                break;
            case "pepper":
                Calories += 50;
                break;
        }
    }
}
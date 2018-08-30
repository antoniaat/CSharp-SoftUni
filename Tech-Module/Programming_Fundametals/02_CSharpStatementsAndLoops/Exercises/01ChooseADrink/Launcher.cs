using System;

public class Launcher
{
    public static void Main()
    {
        var proffesion = Console.ReadLine();
        PrintDrinkForProffesion(proffesion);
    }

    private static void PrintDrinkForProffesion(string proffesion)
    {
        switch (proffesion)
        {
            case "Athlete":
                Console.WriteLine("Water");
                break;

            case "Businessman":
            case "Businesswoman":
                Console.WriteLine("Coffee");
                break;

            case "SoftUni Student":
                Console.WriteLine("Beer");
                break;

            default:
                Console.WriteLine("Tea");
                break;
        }
    }
}
using System;

public class Launcher
{
    public static void Main()
    {
        var proffesion = Console.ReadLine();
        var quantity = int.Parse(Console.ReadLine());

        PrintNeededMoney(proffesion, quantity);
    }

    private static void PrintNeededMoney(string proffesion, int quantity)
    {
        switch (proffesion)
        {
            case "Athlete":
                Console.WriteLine($"The {proffesion} has to pay {quantity * 0.70:f2}.");
                break;

            case "Businessman":
            case "Businesswoman":
                Console.WriteLine($"The {proffesion} has to pay {quantity * 1.00:f2}.");
                break;

            case "SoftUni Student":
                Console.WriteLine($"The {proffesion} has to pay {quantity * 1.70:f2}.");
                break;

            default:
                Console.WriteLine($"The {proffesion} has to pay {quantity * 1.20:f2}.");
                break;
        }
    }
}
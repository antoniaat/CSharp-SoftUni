using System;

public class Launcher
{
    public static double Price;

    public static string Hall;

    public static double Discount;

    public static void Main()
    {
        var countOfPeople = int.Parse(Console.ReadLine());
        var package = Console.ReadLine();

        PriceAndHallForPeopleCount(countOfPeople);
        double priceForPerson = CalculatePriceForOnePerson(package, countOfPeople);

        PrintOffert(priceForPerson);
    }

    private static void PrintOffert(double priceForPerson)
    {
        Console.WriteLine($"We can offer you the {Hall}");
        Console.WriteLine($"The price per person is {priceForPerson:f2}$");
    }

    private static double CalculatePriceForOnePerson(string package, int countOfPeople)
    {
        switch (package)
        {
            case "Normal":
                Price += 500;
                Price -= Price * 0.05;
                break;

            case "Gold":
                Price += 750;
                Price -= Price * 0.1;
                break;

            case "Platinum":
                Price += 1000;
                Price -= Price * 0.15;
                break;
        }

        return Price / countOfPeople;
    }

    private static void PriceAndHallForPeopleCount(int countOfPeople)
    {
        if (countOfPeople <= 50)
        {
            Price = 2500;
            Hall = "Small Hall";
        }
        else if (countOfPeople > 50 && countOfPeople <= 100)
        {
            Price = 5000;
            Hall = "Terrace";
        }
        else if (countOfPeople > 100 && countOfPeople <= 120)
        {
            Price = 7500;
            Hall = "Great Hall";
        }
        else if (countOfPeople > 120)
        {
            Console.WriteLine("We do not have an appropriate hall.");
            Environment.Exit(0);
        }
    }
}
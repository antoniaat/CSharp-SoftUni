using System;

public class Launcher
{
    public static double StudioPrice;

    public static double DoubleRoomPrice;

    public static double SuitePrice;

    public static void Main()
    {
        var month = Console.ReadLine();
        var nightsCount = int.Parse(Console.ReadLine());

        CalculatePrice(month, nightsCount);
        PrintOffert();
    }

    private static void PrintOffert()
    {
        Console.WriteLine($"Studio: {StudioPrice:f2} lv.");
        Console.WriteLine($"Double: {DoubleRoomPrice:f2} lv.");
        Console.WriteLine($"Suite: {SuitePrice:f2} lv.");
    }

    private static void CalculatePrice(string month, int nightsCount)
    {
        switch (month)
        {
            case "May":
            case "October":
                PriceForMayAndOctober(month, nightsCount);
                break;

            case "June":
            case "September":
                PriceForJuneAndSeptember(month, nightsCount);
                break;

            case "July":
            case "August":
            case "December":
                PriceForJulyAugustAndDecember(nightsCount);
                break;
        }
    }

    private static void PriceForJulyAugustAndDecember(int nightsCount)
    {
        StudioPrice = 68;
        DoubleRoomPrice = 77;
        SuitePrice = 89;

        if (nightsCount > 14)
        {
            SuitePrice -= SuitePrice * 0.15;
        }

        StudioPrice *= nightsCount;
        DoubleRoomPrice *= nightsCount;
        SuitePrice *= nightsCount;
    }

    private static void PriceForJuneAndSeptember(string month, int nightsCount)
    {
        StudioPrice = 60;
        DoubleRoomPrice = 72;
        SuitePrice = 82;

        if (nightsCount > 14)
        {
            DoubleRoomPrice -= DoubleRoomPrice * 0.1;
        }

        StudioPrice *= nightsCount;
        DoubleRoomPrice *= nightsCount;
        SuitePrice *= nightsCount;

        // Special discount

        if (nightsCount > 7 && month == "September")
        {
            StudioPrice -= 60;
        }
    }

    private static void PriceForMayAndOctober(string month, int nightsCount)
    {
        StudioPrice = 50;
        DoubleRoomPrice = 65;
        SuitePrice = 75;

        if (nightsCount > 7)
        {
            StudioPrice -= StudioPrice * 0.05;
        }

        StudioPrice *= nightsCount;
        DoubleRoomPrice *= nightsCount;
        SuitePrice *= nightsCount;

        // Special discount

        if (nightsCount > 7 && month == "October")
        {
            StudioPrice -= 50;
        }
    }
}
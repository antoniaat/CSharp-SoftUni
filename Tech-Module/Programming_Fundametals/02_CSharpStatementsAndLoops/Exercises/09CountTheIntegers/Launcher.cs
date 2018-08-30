using System;

public class Launcher
{
    public static void Main()
    {
        Console.WriteLine(CountOfParsedNumbers());
    }

    private static int CountOfParsedNumbers()
    {
        var sum = 0;
        var input = Console.ReadLine();

        while (int.TryParse(input, out var output))
        {
            input = Console.ReadLine();
            sum++;
        }

        return sum;
    }
}
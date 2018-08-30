using System;

public class Launcher
{
    public static void Main()
    {
        var firstNum = int.Parse(Console.ReadLine());
        var secondNum = int.Parse(Console.ReadLine());

        PrintIntervalOfNumbers(firstNum, secondNum);
    }

    private static void PrintIntervalOfNumbers(int firstNum, int secondNum)
    {
        int smallerNumber = Math.Min(firstNum, secondNum);
        int biggerNumber = Math.Max(firstNum, secondNum);

        for (int i = smallerNumber; i <= biggerNumber; i++)
        {
            Console.WriteLine(i);
        }
    }
}
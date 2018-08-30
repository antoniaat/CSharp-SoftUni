using System;

namespace _04BeverageLabels
{
    public class StartUp
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energy = double.Parse(Console.ReadLine());
            var sugar = double.Parse(Console.ReadLine());

            var cal = volume / 100;
            var kcal = energy * cal;
            var sugars = sugar * cal;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{kcal}kcal, {sugars}g sugars");
        }
    }
}
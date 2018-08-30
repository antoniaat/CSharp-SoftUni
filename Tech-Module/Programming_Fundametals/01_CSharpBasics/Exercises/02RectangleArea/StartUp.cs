using System;

namespace _02RectangleArea
{
    public class StartUp
    {
        public static void Main()
        {
            var width = float.Parse(Console.ReadLine());
            var height = float.Parse(Console.ReadLine());
            var area = width * height;
            Console.WriteLine($"{area:f2}");
        }
    }
}
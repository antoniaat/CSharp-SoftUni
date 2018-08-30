namespace _06_Rectangle_Position
{
    using System;
    using System.Linq;

    public class Rectangle_Position
    {
        public static void Main()
        {
            Rectangle r1 = ReadRectangle(), r2 = ReadRectangle();

            Console.WriteLine(r1.IsInside(r2) ? "Inside" :
                "Not inside");
        }

        public static Rectangle ReadRectangle()
        {
            var size = Console.ReadLine().Split().Select(int.Parse);

            var rectangle = new Rectangle()
            {
                Left = size.First(),
                Top = size.Skip(1).First(),
                Width = size.Skip(2).First(),
                Height = size.Skip(3).First()
            };

            return rectangle;
        }
    }
}
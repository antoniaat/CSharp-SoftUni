namespace _05.SortNumbers
{
    using System;
    using System.Linq;

    public class SortNumbers
    {
        public static void Main()
        {
            var list = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .OrderByDescending(x => x)
                .Reverse()
                .ToList();

            Console.WriteLine("{0}", string.Join(" <= ", list));
        }
    }
}

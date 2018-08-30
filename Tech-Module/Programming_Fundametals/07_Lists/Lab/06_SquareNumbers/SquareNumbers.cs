namespace _06.SquareNumbers
{
    using System;
    using System.Linq;

    public class SquareNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            for (var num = 0; num < numbers.Count; num++)
            {
                var result = Math.Sqrt(numbers[num]);

                if (result % 1 == 0) continue;

                numbers.RemoveAt(num);
                num--;
            }

            numbers = numbers
                .OrderBy(x => x)
                .Reverse()
                .ToList();

            Console.WriteLine("{0}", string.Join(" ", numbers));
        }
    }
}

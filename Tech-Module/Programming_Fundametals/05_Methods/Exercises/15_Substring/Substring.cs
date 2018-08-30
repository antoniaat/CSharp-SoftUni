namespace _15.Substring
{
    using System;

    public class Substring
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var step = int.Parse(Console.ReadLine());

            var key = 'p';
            var hasMatch = false;

            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] != key) continue;
                hasMatch = true;

                Console.WriteLine(step + i + 1 > input.Length ? input.Substring(i) : input.Substring(i, step + 1));

                i += step;
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
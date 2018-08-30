using System.Collections.Generic;
using System.Linq;

namespace _02_Entertrain
{
    using System;

    public class Entertrain
    {
        public static void Main()
        {
            var locomotivePower = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var list = new List<int>();

            while (input != "All ofboard!")
            {
                var weight = int.Parse(input);
                list.Add(weight);

                if (list.Sum() > locomotivePower)
                {
                    var average = list.Sum() / list.Count;
                    var closest = list.Aggregate((x, y) => Math.Abs(x - average) < Math.Abs(y - average) ? x : y);
                    list.Remove(closest);
                }

                input = Console.ReadLine();
            }

            list.Reverse();
            Console.Write(string.Join(" ", list));
            Console.WriteLine($" {locomotivePower}");
        }
    }
}

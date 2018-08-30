namespace _04_Supermarket
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Supermarket
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dict = new Dictionary<string, Dictionary<double, int>>();

            while (input != "stocked")
            {
                var inputSplit = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var name = inputSplit[0];
                var price = double.Parse(inputSplit[1]);
                var quantity = int.Parse(inputSplit[2]);

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new Dictionary<double, int>());
                    dict[name].Add(price, 0);
                }
                else
                {
                    dict[name].Add(price, 0);
                }

                dict[name][price] += quantity;

                input = Console.ReadLine();
            }

            var listSum = new List<double>();

            foreach (var product in dict)
            {
                Console.Write($"{product.Key}: ");
                Console.WriteLine($"${product.Value.Keys.Last():f2} * {product.Value.Values.Sum()} = ${product.Value.Keys.Last() * product.Value.Values.Sum():f2}");
                listSum.Add(product.Value.Keys.Last() * product.Value.Values.Sum());
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${listSum.Sum():f2}");
        }
    }
}

using System.Linq;

namespace _07_Inventory_Matcher
{
    using System;

    public class InventoryMatcher
    {
        public static void Main()
        {
            var productsNames = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var productsQuantities = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            var productsPrices = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToArray();

            var product = Console.ReadLine();

            while (product != "done")
            {
                for (int i = 0; i < productsNames.Length; i++)
                {
                    if (product == productsNames[i])
                    {
                        Console.WriteLine($"{product} costs: {productsPrices[i]}; Available quantity: {productsQuantities[i]}");
                    }
                }

                product = Console.ReadLine();
            }
        }
    }
}

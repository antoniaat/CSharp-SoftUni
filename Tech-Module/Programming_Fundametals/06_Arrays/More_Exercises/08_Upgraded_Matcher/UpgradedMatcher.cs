namespace _08_Upgraded_Matcher
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class UpgradedMatcher
    {
        public static void Main()
        {
            var productsNames = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var productsQuantities = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            for (var i = 0; i <= productsNames.Length - productsQuantities.Count; i++)
            {
                productsQuantities.Add(0);
            }

            var productsPrices = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToArray();

            var product = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (product[0] != "done")
            {
                PrintProductPrice(productsNames, productsQuantities, productsPrices, product);

                product = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }
        }

        public static void PrintProductPrice(string[] productsNames, List<long> productsQuantities, decimal[] productsPrices, string[] product)
        {
            var productName = product[0];
            var productNeedQuantity = long.Parse(product[1]);
            var count = 0;

            for (var i = 0; i < productsNames.Length; i++)
            {
                if (productName != productsNames[i] || productNeedQuantity > productsQuantities[i]) continue;

                productsQuantities[i] -= productNeedQuantity;
                Console.WriteLine($"{productName} x {productNeedQuantity} costs {productNeedQuantity * productsPrices[i]:f2}");
                count++;
                break;
            }

            if (count == 0)
            {
                Console.WriteLine($"We do not have enough {productName}");
            }
        }
    }
}

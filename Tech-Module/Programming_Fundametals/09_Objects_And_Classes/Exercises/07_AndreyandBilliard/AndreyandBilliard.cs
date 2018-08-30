namespace _07.AndreyandBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AndreyandBilliard
    {
        public static void Main()
        {
            var entities = ReadEntities();

            var clientsDict = new Dictionary<string, Dictionary<string, Dictionary<decimal, int>>>();

            var currentClient = Console.ReadLine();

            while (currentClient != "end of clients")
            {
                var order = currentClient.Split('-', ',');
                var name = order[0];
                var product = order[1];
                var quantity = int.Parse(order[2]);

                foreach (var currentPrice in entities)
                {
                    if (currentPrice.Key == product)
                    {
                        var price = currentPrice.Value;
                        clientsDict.Add(name, new Dictionary<string, Dictionary<decimal, int>>());
                        clientsDict[name].Add(product, new Dictionary<decimal, int>());
                        clientsDict[name][product].Add(price * quantity, quantity);
                    }
                }

                currentClient = Console.ReadLine();
            }

            PrintResult(clientsDict);
        }

        public static void PrintResult(Dictionary<string, Dictionary<string, Dictionary<decimal, int>>> clientsDict)
        {
            var totalBill = 0M;

            foreach (var kvp in clientsDict.OrderBy(a => a.Key))
            {
                if (kvp.Value.Count == 0) continue;
                Console.WriteLine(kvp.Key);

                foreach (var product in kvp.Value)
                {
                    Console.Write($"-- {product.Key} - ");

                    foreach (var list in product.Value)
                    {
                        Console.WriteLine($"{list.Value}");
                        Console.WriteLine($"Bill: {list.Key:f2}");
                        totalBill += list.Key;
                    }
                }
            }
            Console.WriteLine($"Total bill: {totalBill:f2}");
        }

        public static Dictionary<string, decimal> ReadEntities()
        {
            var amountOfEntities = int.Parse(Console.ReadLine());
            var shop = new Dictionary<string, decimal>();

            for (var i = 0; i < amountOfEntities; i++)
            {
                var currentProductAndPrice = Console.ReadLine().Split('-').ToList();

                var productName = currentProductAndPrice[0];
                var productPrice = decimal.Parse(currentProductAndPrice[1]);

                if (!shop.ContainsKey(productName))
                {
                    shop.Add(productName, productPrice);
                }
                shop[productName] = productPrice;
            }

            return shop;
        }
    }
}
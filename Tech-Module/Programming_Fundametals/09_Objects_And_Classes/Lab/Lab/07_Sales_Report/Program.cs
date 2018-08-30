namespace _07_Sales_Report
{
    using System;
    using System.Linq;

   

    public class Program
    {
        public static void Main()
        {
            Sale[] sales = ReadSales();

            var towns = sales.Select(s => s.Town).Distinct().OrderBy(t => t);

            foreach (var town in towns)
            {
                var salesByTown = sales.Where(s => s.Town == town)
                    .Select(s => s.Price * s.Quantity);
                Console.WriteLine("{0} -> {1:f2}", town, salesByTown.Sum());
            }
        }

        static Sale[] ReadSales()
        {
            var n = int.Parse(Console.ReadLine());

            var sales = new Sale[n];

            for (var i = 0; i < n; i++)
            {
                sales[i] = ReadSale();
            }

            return sales;
        }

        static Sale ReadSale()
        {
            var items = Console.ReadLine().Split();

            return new Sale()
            {
                Town = items[0],
                Product = items[1],
                Price = decimal.Parse(items[2]),
                Quantity = decimal.Parse(items[3])
            };
        }


    }
}

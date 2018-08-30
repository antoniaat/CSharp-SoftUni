namespace _01_SoftuniCoffeeOrders
{
    using System;

    public class SoftuniCoffeeOrders
    {
        public static void Main()
        {
            var n = decimal.Parse(Console.ReadLine());
            decimal totalPrice = 0;

            for (int i = 1; i <= n; i++)
            {
                var price = decimal.Parse(Console.ReadLine());
                var dateStr = Console.ReadLine();
                DateTime date = DateTime.ParseExact(dateStr, "d/M/yyyy", null);
                var daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
                var capsulesCount = decimal.Parse(Console.ReadLine());

                var priceForOne = daysInMonth * capsulesCount * price;
                Console.WriteLine($"The price for the coffee is: ${priceForOne:f2}");

                totalPrice += priceForOne;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}

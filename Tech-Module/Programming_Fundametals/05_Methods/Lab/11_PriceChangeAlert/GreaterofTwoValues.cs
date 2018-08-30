namespace _11.Price_Change_Alert
{
    using System;

    public class GreaterofTwoValues
    {
        public static void Main()
        {
            var numberOfStockPrices = int.Parse(Console.ReadLine());
            var threshold = double.Parse(Console.ReadLine());
            var lastPrice = double.Parse(Console.ReadLine());

            for (var i = 0; i < numberOfStockPrices - 1; i++)
            {
                var currentPrice = double.Parse(Console.ReadLine());
                var difference = GetPercentage(lastPrice, currentPrice);
                var hasDifference = HasDifference(difference, threshold);
                var message = GetNotification(currentPrice, lastPrice, difference, hasDifference);
                Console.WriteLine(message);
                lastPrice = currentPrice;
            }
        }

        public static string GetNotification(double currentPrice, double lastPrice, double difference, bool hasDifference)
        {
            var output = string.Empty;

            if (difference == 0)
            {
                output = string.Format($"NO CHANGE: {currentPrice}");
            }
            else if (!hasDifference)
            {
                output = string.Format($"MINOR CHANGE: {lastPrice} to {currentPrice} ({difference * 100:F2}%)");
            }
            else if (hasDifference && (difference > 0))
            {
                output = string.Format($"PRICE UP: {lastPrice} to {currentPrice} ({difference * 100:F2}%)");
            }
            else if (hasDifference && (difference < 0))
            {
                output = string.Format($"PRICE DOWN: {lastPrice} to {currentPrice} ({difference * 100:F2}%)");
            }

            return output;
        }

        public static bool HasDifference(double threshold, double isDiff)
        {
            return Math.Abs(threshold) >= isDiff;
        }

        public static double GetPercentage(double lastPrice, double currentPrice)
        {
            var difference = (currentPrice - lastPrice) / lastPrice;
            return difference;
        }
    }
}
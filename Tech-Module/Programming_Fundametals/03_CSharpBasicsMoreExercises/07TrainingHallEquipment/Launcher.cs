using System;

namespace _07TrainingHallEquipment
{
    // Program which equipping the new halls with all the necessary items. You will receive from user a budget and a list of items to buy.
    public class Launcher
    {
        private static double subTotal;

        public static void Main()
        {
            var budget = float.Parse(Console.ReadLine());
            var numberOfItems = int.Parse(Console.ReadLine());

            BuyItems(budget, numberOfItems);
            PrintInformationAboutBudget(budget);
        }

        private static void BuyItems(float budget, int numberOfItems)
        {
            for (var i = 1; i <= numberOfItems; i++)
            {
                var itemName = Console.ReadLine();
                var itemPrice = float.Parse(Console.ReadLine());
                var itemCount = int.Parse(Console.ReadLine());

                subTotal += itemPrice * itemCount;
                budget -= itemPrice * itemCount;

                Console.WriteLine(itemCount == 1
                    ? $"Adding {itemCount} {itemName} to cart."
                    : $"Adding {itemCount} {itemName}s to cart.");
            }
        }

        private static void PrintInformationAboutBudget(float budget)
        {
            if (budget < 0)
            {
                Console.WriteLine($"Subtotal: ${subTotal:f2}");
                budget = Math.Abs(budget);
                Console.WriteLine($"Not enough. We need ${budget:f2} more.");
            }
            else
            {
                Console.WriteLine($"Subtotal: ${subTotal:f2}");
                Console.WriteLine($"Money left: ${budget:f2}");
            }
        }
    }
}
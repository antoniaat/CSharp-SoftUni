namespace _01_SweetDessert
{
    using System;

    public class SweetDessert
    {
        public static void Main()
        {
            var money = decimal.Parse(Console.ReadLine());
            var guests = int.Parse(Console.ReadLine());
            var priceForOneBananna = decimal.Parse(Console.ReadLine());
            var priceForOneEgg = decimal.Parse(Console.ReadLine());
            var priceForKiloBerries = decimal.Parse(Console.ReadLine());

            var portions = guests / 6;
            if (6 * portions < guests) portions++;

            var sum = portions * (2 * priceForOneBananna) + portions * (4 * priceForOneEgg) +
                      portions * (0.2M * priceForKiloBerries);

            if (sum <= money)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {sum:f2}lv.");
            }
            else
            {
                var need = sum - money;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {need:f2}lv more.");
            }
        }
    }
}

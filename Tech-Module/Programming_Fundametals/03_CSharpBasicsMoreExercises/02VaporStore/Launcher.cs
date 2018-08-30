using System;

namespace _02VaporStore
{
    // Vapor Store is store which help you to buy some video games.
    public class Launcher
    {
        private static double sum;
        private static double price;
        private static double currentBalance;

        public static void Main()
        {
            var readCurrentBalance = double.Parse(Console.ReadLine());
            currentBalance = readCurrentBalance;
            BuyGames();
        }

        private static void BuyGames()
        {
            string currentGame;
            while ((currentGame = Console.ReadLine()) != "Game Time")
            {
                if (currentBalance == 0.00)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                switch (currentGame)
                {
                    case "OutFall 4":
                        BuyOutFallGame();
                        break;

                    case "CS: OG":
                        BuyCsOgGame();
                        break;

                    case "Zplinter Zell":
                        BuyZplinterZellGame();
                        break;

                    case "Honored 2":
                        BuyHonoredGame();
                        break;

                    case "RoverWatch":
                        BuyRoverWatchGame();
                        break;

                    case "RoverWatch Origins Edition":
                        BuyRoverWatchOriginsGame();
                        break;

                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
            }

            CalculateGameTimeAndCurrentBalance();
        }

        private static void CalculateGameTimeAndCurrentBalance()
        {
            Console.WriteLine($"Total spent: ${sum:f2}. Remaining: ${currentBalance:f2}");
        }

        private static void BuyRoverWatchOriginsGame()
        {
            price = 39.99;

            if (currentBalance < price)
                Console.WriteLine("Too Expensive");
            else
            {
                currentBalance -= price;
                sum += price;
                Console.WriteLine("Bought RoverWatch Origins Edition");
            }
        }

        private static void BuyRoverWatchGame()
        {
            price = 29.99;

            if (currentBalance < price)
                Console.WriteLine("Too Expensive");
            else
            {
                currentBalance -= price;
                sum += price;
                Console.WriteLine("Bought RoverWatch");
            }
        }

        private static void BuyHonoredGame()
        {
            price = 59.99;

            if (currentBalance < price)
                Console.WriteLine("Too Expensive");
            else
            {
                currentBalance -= price;
                sum += price;
                Console.WriteLine("Bought Honored 2");
            }
        }

        private static void BuyZplinterZellGame()
        {
            price = 19.99;

            if (currentBalance < price)
            {
                Console.WriteLine("Too Expensive");
            }
            else
            {
                currentBalance -= price;
                sum += price;
                Console.WriteLine("Bought Zplinter Zell");
            }
        }

        private static void BuyCsOgGame()
        {
            price = 15.99;

            if (currentBalance < price)
            {
                Console.WriteLine("Too Expensive");
            }
            else
            {
                currentBalance -= price;
                sum += price;
                Console.WriteLine("Bought CS: OG");
            }
        }

        private static void BuyOutFallGame()
        {
            price = 39.99;

            if (currentBalance < price)
            {
                Console.WriteLine("Too Expensive");
            }
            else
            {
                currentBalance -= price;
                sum += price;
                Console.WriteLine("Bought OutFall 4");
            }
        }
    }
}
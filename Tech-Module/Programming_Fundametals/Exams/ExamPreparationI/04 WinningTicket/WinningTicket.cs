namespace _04_WinningTicket
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WinningTicket
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string pattern = @"(.+[@#$^]{6})(.+[@#$^]{6}.+)";
            Regex regex = new Regex(pattern);
            var count = 0;

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }

                else
                {
                    if (regex.IsMatch(input[i]))
                    {
                        count = input[i].Count(x => x == '$');

                        if (count == 20)
                        {
                            Console.WriteLine($"ticket \"{input[i]}\" - {count / 2}$ Jackpot!");
                            continue;
                        }

                        if (count >= 12 && count < 20)
                        {
                            Console.WriteLine($"ticket \"{input[i]}\" - {count / 2}$");
                            continue;
                        }

                        count = input[i].Count(x => x == '@');

                        if (count == 20)
                        {
                            Console.WriteLine($"ticket \"{input[i]}\" - {count / 2}@ Jackpot!");
                            continue;
                        }

                        if (count >= 12 && count < 20)
                        {
                            Console.WriteLine($"ticket \"{input[i]}\" - {count / 2}@");
                            continue;
                        }

                        count = input[i].Count(x => x == '#');

                        if (count == 20)
                        {
                            Console.WriteLine($"ticket \"{input[i]}\" - {count / 2}# Jackpot!");
                            continue;
                        }

                        if (count >= 12 && count < 20)
                        {
                            Console.WriteLine($"ticket \"{input[i]}\" - {count / 2}#");
                            continue;
                        }

                        count = input[i].Count(x => x == '^');

                        if (count == 20)
                        {
                            Console.WriteLine($"ticket \"{input[i]}\" - {count / 2}^ Jackpot!");
                            continue;
                        }

                        if (count >= 12 && count < 20)
                        {
                            Console.WriteLine($"ticket \"{input[i]}\" - {count / 2}^");
                            continue;
                        }

                        else
                        {
                            Console.WriteLine($"ticket \"{input[i]}\" - no match");
                        }
                    }

                    else
                    {
                        Console.WriteLine($"ticket \"{input[i]}\" - no match");
                    }
                }
            }
        }
    }
}


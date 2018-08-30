namespace _05.HandsofCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HandsofCards
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var people = new Dictionary<string, Dictionary<string, int>>();

            while (input != "JOKER")
            {
                var commandArgs = input.Split(':');
                var name = commandArgs[0];
                var cardsArgs = commandArgs[1]
                    .Trim()
                    .Split( new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                if (!people.ContainsKey(name))
                {
                    people.Add(name, new Dictionary<string, int>());
                    AddCardsToPerson(people[name], cardsArgs);
                }

                else
                {
                    AddCardsToPerson(people[name], cardsArgs);
                }

                input = Console.ReadLine();
            }

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Key}: {person.Value.Values.Sum()}");
            }
        }

        public static void AddCardsToPerson(Dictionary<string, int> person, string[] cardsArgs)
        {
            foreach (var card in cardsArgs)
            {
                if (!person.ContainsKey(card))
                {
                    person.Add(card, GetCardValue(card));
                }
            }
        }

        public static int GetCardValue(string card)
        {
            var power = 0;

            switch (card[0])
            {
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    power += (int) card[0] - 48;
                    break;

                case '1':
                    power += 10;
                    break;
                case 'J':
                    power += 11;
                    break;
                case 'Q':
                    power += 12;
                    break;
                case 'K':
                    power += 13;
                    break;
                case 'A':
                    power += 14;
                    break;
            }

            switch (card[card.Length-1])
            {
                case 'S':
                    power *= 4;
                    break;
                case 'H':
                    power *= 3;
                    break;
                case 'D':
                    power *= 2;
                    break;
                case 'C':
                    power *= 1;
                    break;
            }

            return power;
        }
    }
}

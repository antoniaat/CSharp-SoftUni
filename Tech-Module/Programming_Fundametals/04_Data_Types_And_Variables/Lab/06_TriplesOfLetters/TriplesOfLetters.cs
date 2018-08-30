using System;

namespace _06.Triples_of_Letters
{
    public class TriplesOfLetters
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var firstLetter = 0;
            var secondLetter = 0;
            var thirdLetter = 0;
            var letters = 0;

            for (var i = 'a'; i <= 'z'; i++)
            {
                firstLetter++;

                if (firstLetter == n)
                    break;
                Console.Write(i);

                for (var j = 'a'; j <= 'z'; j++)
                {
                    secondLetter++;

                    if (secondLetter == n)
                        break;
                    if (firstLetter == n)
                        break;
                    Console.Write(j);

                    for (var k = 'a'; k <= 'z'; k++)
                    {
                        thirdLetter++;

                        if (secondLetter == n)
                            break;
                        if (firstLetter == n)
                            break;
                        if (thirdLetter == n)
                            break;
                        Console.WriteLine(k);
                    }
                }
            }
        }
    }
}
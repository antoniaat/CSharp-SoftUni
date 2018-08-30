namespace _02_PokemonDon_tGo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PokemonDon_tGo
    {
        public static void Main()
        {
            var array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            var removedElements = new List<long>();

            while (array.Count != 0)
            {
                var currentIndex = int.Parse(Console.ReadLine());

                if (currentIndex < 0)
                {
                    long removedNumber = array[0];
                    removedElements.Add(removedNumber);
                    array.RemoveAt(0);
                    long lastElement = array.Last();
                    array.Insert(0, lastElement);

                    for (int i = 0; i < array.Count; i++)
                    {
                        if (array[i] < removedNumber)
                        {
                            array[i] += removedNumber;
                        }
                        else
                        {
                            array[i] -= removedNumber;
                        }
                    }
                }

                else if (currentIndex > array.Count - 1)
                {
                    var removedNumber = array.Last();
                    removedElements.Add(removedNumber);
                    array.RemoveAt(array.Count - 1);
                    var firstElement = array[0];
                    array.Add(firstElement);

                    for (int i = 0; i < array.Count; i++)
                    {
                        if (array[i] <= removedNumber)
                        {
                            array[i] += removedNumber;
                        }
                        else
                        {
                            array[i] -= removedNumber;
                        }
                    }
                }

                else if (array.Count >= currentIndex)
                {
                    var removedNumber = array[currentIndex];
                    removedElements.Add(removedNumber);
                    array.RemoveAt(currentIndex);

                    for (int i = 0; i < array.Count; i++)
                    {
                        if (array[i] <= removedNumber)
                        {
                            array[i] += removedNumber;
                        }
                        else
                        {
                            array[i] -= removedNumber;
                        }
                    }
                }
            }

            Console.WriteLine(removedElements.Sum());
        }
    }
}

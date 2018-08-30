namespace _01_Sort_Times
{
    using System;
    using System.Linq;
    using System.Globalization;

    public class SortTimes
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var orderedList = input.Select(t => DateTime.ParseExact(t, "HH:mm", CultureInfo.InvariantCulture)).ToList();

            var lastIndex = orderedList.Count - 1;
            orderedList = orderedList.OrderByDescending(x => x).Reverse().ToList();

            foreach (var date in orderedList)
            {
                if (orderedList[lastIndex] == date)
                {
                    Console.WriteLine($"{date.Hour:D2}:{date.Minute:D2}");
                }
                else
                {
                    Console.Write($"{date.Hour:D2}:{date.Minute:D2}, ");
                }
            }
        }
    }
}

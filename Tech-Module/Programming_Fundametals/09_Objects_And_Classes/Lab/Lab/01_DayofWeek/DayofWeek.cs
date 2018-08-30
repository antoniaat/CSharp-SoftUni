namespace _01.DayofWeek
{
    using System;
    using System.Globalization;

    public class DayofWeek
    {
        public static void Main()
        {
            string dateAsText = Console.ReadLine();

            DateTime date = DateTime.ParseExact(dateAsText, "d-M-yyyy",
                CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}

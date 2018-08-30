namespace _01_Day_of_Week
{
    using System;

    public class DayofWeek
    {
        public static void Main()
        {
            var currentDay = int.Parse(Console.ReadLine());

            string[] days =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };

            if (currentDay >= 1 && currentDay <= 7)
            {
                Console.WriteLine(days[currentDay - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}

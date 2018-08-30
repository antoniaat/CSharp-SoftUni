namespace _01.CountWorkingDays
{
    using System;
    using System.Globalization;
    using System.Linq;

    public class CountWorkingDays
    {
        public static void Main()
        {
            var startDate = DateTime
                .ParseExact(Console.ReadLine(), "dd-MM-yyyy",
                    CultureInfo.InvariantCulture);

            var endDate = DateTime
                .ParseExact(Console.ReadLine(), "dd-MM-yyyy",
                    CultureInfo.InvariantCulture);

            DateTime[] holidays =
            {
                DateTime
                    .ParseExact("01-01-1970", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),
                DateTime
                    .ParseExact("03-03-1970", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),
                DateTime
                    .ParseExact("01-05-1970", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),
                DateTime
                    .ParseExact("06-05-1970", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),
                DateTime
                    .ParseExact("24-05-1970", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),
                DateTime
                    .ParseExact("06-09-1970", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),
                DateTime
                    .ParseExact("22-09-1970", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),
                DateTime
                    .ParseExact("01-11-1970", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),
                DateTime
                    .ParseExact("24-12-1970", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),
                DateTime
                    .ParseExact("25-12-1970", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),
                DateTime
                    .ParseExact("26-12-1970", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),
            };

            var workingDays = 0;

            for (var currentDay = startDate; currentDay <= endDate; currentDay.AddDays(1))
            {
                if (currentDay.DayOfWeek != DayOfWeek.Saturday && currentDay.DayOfWeek != DayOfWeek.Sunday)
                {
                    var exist = holidays.Any(d => d.Month == currentDay.Month && d.Day == currentDay.Day);

                    if (!exist) workingDays++;
                }

                currentDay = currentDay.AddDays(1);
            }

            Console.WriteLine(workingDays);
        }
    }
}
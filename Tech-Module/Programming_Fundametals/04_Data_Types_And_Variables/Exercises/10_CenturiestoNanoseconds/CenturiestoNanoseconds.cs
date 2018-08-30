using System;

namespace _10.CenturiestoNanoseconds
{
    public class CenturiestoNanoseconds
    {
        public static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = 24 * days;
            long minutes = 60 * hours;
            long seconds = 60 * minutes;
            long miliseconds = 1000 * seconds;
            decimal microseconds = 1000 * miliseconds;
            decimal nanoseonds = 1000 * microseconds;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseonds} nanoseconds");
        }
    }
}
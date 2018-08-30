using System.Runtime.Remoting.Messaging;

namespace _01_SinoTheWalker
{
    using System;

    public class SinoTheWalker
    {
        public static void Main()
        {
            string startTimeStr = Console.ReadLine();
            int steps = int.Parse(Console.ReadLine()) % 86400;
            int timeInSecondsForOneStep = int.Parse(Console.ReadLine()) % 86400;

            DateTime myDate = DateTime.ParseExact(startTimeStr, "HH:mm:ss",
                System.Globalization.CultureInfo.InvariantCulture);

            var walkTimeInSeconds = steps * timeInSecondsForOneStep;

            DateTime result = myDate.AddSeconds(walkTimeInSeconds);

            Console.WriteLine($"Time Arrival: {result:HH:mm:ss}");
        }
    }
}

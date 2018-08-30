using System;

namespace _03MilesToKilometers
{
    public class StartUp
    {
        public static void Main()
        {
            var mile = double.Parse(Console.ReadLine());
            var kilometers = mile * 1.60934;
            Console.WriteLine("{0:f2}", kilometers);
        }
    }
}
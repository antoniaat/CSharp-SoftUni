namespace _01_Hornet_Wings
{
    using System;

    public class Hornet_Wings
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int rests = n / p;
            long seconds = rests * 5L;
            double distance = (n / 1000) * m;
            seconds += (n / 100);

            Console.WriteLine("{0:F2} m.", distance);
            Console.WriteLine("{0} s.", seconds);
        }
    }
}

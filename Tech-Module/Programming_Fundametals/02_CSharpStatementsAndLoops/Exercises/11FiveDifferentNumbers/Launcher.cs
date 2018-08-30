using System;

namespace _11FiveDifferentNumbers
{
    public class Launcher
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            if (b - a >= 5)
            {
                GenerateNumbers(a, b);
            }

            else
            {
                Console.WriteLine("No");
            }
        }

        private static void GenerateNumbers(int a, int b)
        {
            for (int first = a; first <= b; first++)
            {
                for (int second = first; second <= b; second++)
                {
                    for (int third = second; third <= b; third++)
                    {
                        for (int forth = third; forth <= b; forth++)
                        {
                            for (int fifth = forth; fifth <= b; fifth++)
                            {
                                if (a <= first && first < second && second < third && third < forth && forth < fifth)
                                {
                                    Console.WriteLine($"{first} {second} {third} {forth} {fifth}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

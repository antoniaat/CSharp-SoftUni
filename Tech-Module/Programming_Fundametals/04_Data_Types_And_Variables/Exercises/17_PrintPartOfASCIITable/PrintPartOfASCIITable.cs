using System;

namespace _17.PrintPartOfASCIITable
{
    public class PrintPartOfASCIITable
    {
        public static void Main()
        {
            int firstChar = int.Parse(Console.ReadLine());
            int secondChar = int.Parse(Console.ReadLine());

            for (int i = firstChar; i <= secondChar; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
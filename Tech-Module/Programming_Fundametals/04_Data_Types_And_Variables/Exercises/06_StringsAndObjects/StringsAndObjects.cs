using System;

namespace _06.Strings_And_Objects
{
    public class StringsAndObjects
    {
        public static void Main()
        {
            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();
            object result = firstLine + " " + secondLine;
            string final = (string)result;
            Console.WriteLine(final);
        }
    }
}
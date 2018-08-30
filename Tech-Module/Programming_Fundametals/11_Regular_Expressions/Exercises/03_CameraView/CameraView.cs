using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03_CameraView
{
    using System;
    using System.Linq;

    public class CameraView
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var skipElements = numbers[0];
            var takeElements = numbers[1];

            var input = Console.ReadLine();

            string pattern = @"(\b([|<]+[A-Za-z]+))+";

            var result = Regex.Matches(input, pattern);

            var camera = new List<string>();

            foreach (Match m in result)
            {
                m.Groups
            }


        }
    }
}

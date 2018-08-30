namespace _07_TakeSkip_Rope
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class TakeSkipRope
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var digits = ExtractNumber(input);
            var digitsList = NumbersList(digits);
            input = Regex.Replace(input, "[0-9]", "");
            var takeList = new List<int>();
            var skipList = new List<int>();

            for (var i = 0; i < digitsList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(digitsList[i]);
                }
                else
                {
                    skipList.Add(digitsList[i]);
                }
            }

            var sb = new StringBuilder();
            var total = 0;

            for (var i = 0; i < takeList.Count; i++)
            {
                var array = input.Skip(total).Take(takeList[i]).ToArray();

                total += skipList[i];
                total += takeList[i];

                var result = new string(array);
                sb.Append(result);
            }

            Console.WriteLine(sb.ToString());
        }

        public static string ExtractNumber(string input) => new string(input.Where(char.IsDigit).ToArray());

        public static List<int> NumbersList(string digits)
        {
            return digits.Select(ch => (int)char.GetNumericValue(ch)).ToList();
        }
    }
}

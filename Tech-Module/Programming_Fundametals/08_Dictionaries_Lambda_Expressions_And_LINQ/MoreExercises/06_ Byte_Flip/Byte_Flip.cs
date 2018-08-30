namespace _06__Byte_Flip
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;

    public class Byte_Flip
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            for (var i = 0; i < input.Count; i++)
            {
                if (input[i].Length == 2) continue;

                input.Remove(input[i]);
                i--;
            }

            for (var i = 0; i < input.Count; i++)
            {
                input[i] = Reverse(input[i]);
            }

            var reversedList = new List<string>();

            for (var i = input.Count - 1; i >= 0; i--)
            {
                reversedList.Add(input[i]);
            }

            var sb = new StringBuilder();

            foreach (var hs in reversedList)
            {
                sb.Append(Convert.ToChar(Convert.ToUInt32(hs, 16)));
            }

            Console.WriteLine(sb.ToString());
        }

        public static string Reverse(string s)
        {
            var charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

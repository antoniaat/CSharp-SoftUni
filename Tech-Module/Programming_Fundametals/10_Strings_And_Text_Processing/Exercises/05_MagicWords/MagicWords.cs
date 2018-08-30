namespace _05_MagicWords
{
    using System;
    using System.Linq;

    public class MagicWords
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var str1 = input[0];
            var str2 = input[1];
            var result = AreExchangeable(str1, str2);

            if (result)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        public static Boolean AreExchangeable(string str1, string str2)
        {
            bool AreExchangeable = false;
            var newStr1 = str1.Distinct().ToArray();
            var newStr2 = str2.Distinct().ToArray();

            if (newStr1.Length == newStr2.Length)
            {
                AreExchangeable = true;
            }

            return AreExchangeable;
        }
    }
}

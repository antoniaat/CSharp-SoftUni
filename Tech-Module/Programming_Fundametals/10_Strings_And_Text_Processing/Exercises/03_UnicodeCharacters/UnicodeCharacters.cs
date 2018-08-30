namespace _03_UnicodeCharacters
{
    using System;
    using System.Text;

    public class UnicodeCharacters
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            foreach (char c in input)
            {
                sb.Append("\\u");
                sb.Append(String.Format("{0:x4}", (int)c));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}

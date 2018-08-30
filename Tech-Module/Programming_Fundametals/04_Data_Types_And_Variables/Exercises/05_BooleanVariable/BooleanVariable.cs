using System;

namespace _05.Boolean_Variable
{
    public class BooleanVariable
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            bool result = Convert.ToBoolean(text);

            if (result)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
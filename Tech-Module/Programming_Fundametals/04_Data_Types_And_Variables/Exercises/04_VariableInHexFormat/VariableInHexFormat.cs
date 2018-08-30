namespace _04.Variable_in_Hex_Format
{
    using System;

    public class VariableInHexFormat
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            int secondNumber = Convert.ToInt32(number, 16);
            Console.WriteLine(secondNumber);
        }
    }
}
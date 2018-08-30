namespace _18.SeqOfCommands
{
    using System;
    using System.Linq;

    public class SeqOfCommands
    {
        public static void Main()
        {
            Console.ReadLine();

            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            var commandLine = Console.ReadLine();

            while (!commandLine.Equals("stop"))
            {
                var arguments = new int[2];
                var stringParams = commandLine.Split(' ');
                if (stringParams.Length > 1)
                {
                    arguments[0] = int.Parse(stringParams[1]);
                    arguments[1] = int.Parse(stringParams[2]);
                }
                numbers = PerformAction(numbers, stringParams[0], arguments);
                ArrayWriteLine(numbers);
                commandLine = Console.ReadLine();
            }
        }

        public static long[] PerformAction(long[] nums, string action, int[] args)
        {
            var index = args[0] - 1;
            var value = args[1];

            switch (action)
            {
                case "multiply":
                    nums[index] *= value;
                    break;

                case "add":
                    nums[index] += value;
                    break;

                case "subtract":
                    nums[index] -= value;
                    break;

                case "lshift":
                    nums = ShiftElementsLeft(nums);
                    break;

                case "rshift":
                    nums = ShiftElementsRight(nums);
                    break;
            }
            return nums;
        }

        public static long[] ShiftElementsRight(long[] array)
        {
            var lastElement = array[array.Length - 1];
            for (var i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = lastElement;
            return array;
        }

        public static long[] ShiftElementsLeft(long[] array)
        {
            var firstElement = array[0];
            for (var i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = firstElement;
            return array;
        }

        public static void ArrayWriteLine(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
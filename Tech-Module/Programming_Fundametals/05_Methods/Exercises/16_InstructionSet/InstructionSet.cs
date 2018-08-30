namespace _16.Instruction_Set
{
    using System;

    public class InstructionSet
    {
        public static void Main()
        {
            {
                var input = Console.ReadLine();

                while (input != "END")
                {
                    var codeArgs = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    long result = 0;

                    switch (codeArgs[0])
                    {
                        case "INC":
                        {
                            var operandOne = long.Parse(codeArgs[1]);
                            operandOne++;
                            result += operandOne;
                            Console.WriteLine(result);
                            break;
                        }
                        case "DEC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            operandOne--;
                            result += operandOne;
                            Console.WriteLine(result);
                            break;
                        }
                        case "ADD":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            Console.WriteLine(result);
                            break;
                        }
                        case "MLA":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne * operandTwo;
                            Console.WriteLine(result);
                            break;
                        }
                    }

                    input = Console.ReadLine();
                }
            }
        }
    }
}
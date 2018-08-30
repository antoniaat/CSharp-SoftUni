using System;

namespace _06DNASequences
{
    // Program, which prints all the possible nucleic acid sequences (A, C, G and T), in the range [AAA…TTT].
    public class Launcher
    {
        private static int sum;

        // Each nucleotide has a corresponding numeric value – A - 1, C - 2, G - 3, T - 4.
        private const int A = 1;

        private const int C = 2;
        private const int G = 3;
        private const int T = 4;

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            PrintAcidSequences(n);
        }

        private static void PrintAcidSequences(int n)
        {
            var fourToRow = 0;
            var secondLetter = string.Empty;
            var forthLetter = string.Empty;
            var thirdLetter = string.Empty;

            for (var one = A; one <= T; one++)
            {
                for (var two = A; two <= T; two++)
                {
                    for (var three = A; three <= T; three++)
                    {
                        sum = 0;

                        if (one == A)
                        {
                            sum++;
                            secondLetter = "A";
                        }

                        if (two == A)
                        {
                            sum++;
                            thirdLetter = "A";
                        }

                        if (three == A)
                        {
                            sum++;
                            forthLetter = "A";
                        }
                        if (one == C)
                        {
                            sum += 2;
                            secondLetter = "C";
                        }
                        if (two == C)
                        {
                            sum += 2;
                            thirdLetter = "C";
                        }
                        if (three == C)
                        {
                            sum += 2;
                            forthLetter = "C";
                        }
                        if (one == G)
                        {
                            sum += 3;
                            secondLetter = "G";
                        }
                        if (two == G)
                        {
                            sum += 3;
                            thirdLetter = "G";
                        }
                        if (three == G)
                        {
                            sum += 3;
                            forthLetter = "G";
                        }
                        if (one == T)
                        {
                            sum += 4;
                            secondLetter = "T";
                        }
                        if (two == T)
                        {
                            sum += 4;
                            thirdLetter = "T";
                        }
                        if (three == T)
                        {
                            sum += 4;
                            forthLetter = "T";
                        }

                        string firstLetter;
                        string fifthLetter;
                        if (sum >= n)
                        {
                            firstLetter = "O";
                            fifthLetter = "O";
                        }
                        else
                        {
                            firstLetter = "X";
                            fifthLetter = "X";
                        }

                        Console.Write($"{firstLetter}{secondLetter}{thirdLetter}{forthLetter}{fifthLetter} ");
                        fourToRow++;

                        if (fourToRow == 4)
                        {
                            fourToRow = 0;
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
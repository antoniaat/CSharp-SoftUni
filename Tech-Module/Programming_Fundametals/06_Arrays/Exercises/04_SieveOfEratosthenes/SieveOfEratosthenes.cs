namespace _04_SieveOfEratosthenes
{
    using System;

    public class SieveOfEratosthenes
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var arrInput = new int[n + 1];
            var checkNums = new bool[n + 1];

            string primeNums = null;

            for (var i = 0; i <= n; i++)
            {
                arrInput[i] = i;
                checkNums[i] = true;
            }

            primeNums = SieveOfErat(arrInput, checkNums, primeNums);

            Console.WriteLine(primeNums.Trim());
        }

        private static string SieveOfErat(int[] arrInput, bool[] checkNums, string primeNums)
        {
            checkNums[0] = false;
            checkNums[1] = false;

            for (var i = 0; i < arrInput.Length; i++)
            {
                if (!checkNums[i]) continue;
                primeNums += $"{arrInput[i]} ";

                for (var j = i + 1; j < arrInput.Length; j++)
                {
                    if (arrInput[j] % i == 0 && checkNums[j])
                    {
                        checkNums[j] = false;
                    }
                }
            }

            return primeNums;
        }
    }
}
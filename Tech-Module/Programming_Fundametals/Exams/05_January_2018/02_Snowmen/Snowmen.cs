using System;
using System.Linq;

namespace _02_Snowmen
{
    public class Snowmen
    {
        public static void Main()
        {
            var snowmen = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            
            while (snowmen.Count > 1)
            {
                for (var i = 0; i < snowmen.Count; i++)
                {
                    var attacker = i;
                    var target = snowmen[i];

                    if(snowmen[i] == -1) break;
                    
                    if (target > snowmen.Count -1 || attacker > snowmen.Count - 1)
                    {
                        target = target % snowmen.Count;
                    }

                    var difference = Math.Abs(target - attacker);

                    if (target == attacker)
                    {
                        //attacker suicide
                        Console.WriteLine($"{attacker} performed harakiri");
                        snowmen[i] = -1;
                    }

                    else if (difference % 2 == 0)
                    {
                        //attacker wins
                        Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                        snowmen[target] = -1;

                    }
                    else
                    {
                        //target wins
                        Console.WriteLine($"{attacker} x {target} -> {target} wins");
                        snowmen[attacker] = -1;
                    }

                    var count = snowmen.Where(x => x != -1);
                    if (count.Count() == 1) break;
                }

              snowmen.RemoveAll(item => item == -1);
            }
        }
    }
}
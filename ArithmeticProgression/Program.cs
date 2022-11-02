using System;
using System.Collections.Generic;

namespace ArithmeticProgression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sequence = GetInputFromKeyboard();

            var checker = new ArithmeticProgressionChecker(sequence);

            if (checker.IsProgression())
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            Console.ReadLine();
        }

        private static List<int> GetInputFromKeyboard()
        {
            var n = int.Parse(Console.ReadLine());//no validation requested for this example.

            var sequence = new List<int>();

            for (int i = 0; i < n; i++)
            {
                sequence.Add(int.Parse(Console.ReadLine()));
            }

            return sequence;
        }
    }
}

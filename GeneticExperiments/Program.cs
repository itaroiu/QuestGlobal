using System;

namespace GeneticExperints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine(); // no validation requested for this example.

            var synthetizer = new CompoundSynthesizer(input);

            Console.WriteLine(synthetizer.Synthesize());

            Console.ReadLine();
        }
    }
}

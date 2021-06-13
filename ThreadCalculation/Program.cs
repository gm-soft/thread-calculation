using System;
using ThreadCalculation.Calculators;

namespace ThreadCalculation
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                new MultithreadCalculator(new RandomCollection(100_000).ToArray()).Sum());
        }
    }
}
using BenchmarkDotNet.Attributes;
using ThreadCalculation;
using ThreadCalculation.Calculators;

namespace Benchmark
{
    public class Benchmark
    {
        [Benchmark]
        [Arguments(10_000)]
        [Arguments(100_000)]
        [Arguments(1_000_000)]
        public int Simple(int size)
        {
            return new SimpleCalculator(new RandomCollection(size).ToArray()).Sum();
        }
        
        [Benchmark]
        [Arguments(10_000)]
        [Arguments(100_000)]
        [Arguments(1_000_000)]
        public int Parallel(int size)
        {
            return new ParallelSumCalculator(new RandomCollection(size).ToArray()).Sum();
        }
        
        [Benchmark]
        [Arguments(10_000)]
        [Arguments(100_000)]
        [Arguments(1_000_000)]
        public int Multithread(int size)
        {
            return new MultithreadCalculator(new RandomCollection(size).ToArray()).Sum();
        }
    }
}
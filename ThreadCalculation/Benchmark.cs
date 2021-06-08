using BenchmarkDotNet.Attributes;
using ThreadCalculation.Calculators;

namespace ThreadCalculation
{
    public class Benchmark
    {
        [Benchmark]
        [Arguments(10_000)]
        [Arguments(100_000)]
        [Arguments(1_000_000)]
        public int Simple(int size)
        {
            return new SimpleCalculator(new RandomCollection(size)).Sum();
        }
        
        [Benchmark]
        [Arguments(10_000)]
        [Arguments(100_000)]
        [Arguments(1_000_000)]
        public int Parallel(int size)
        {
            return new ParallelSumCalculator(new RandomCollection(size)).Sum();
        }
        
        [Benchmark]
        [Arguments(10_000)]
        [Arguments(100_000)]
        [Arguments(1_000_000)]
        public int Multithread(int size)
        {
            return new MultithreadCalculator(new RandomCollection(size)).Sum();
        }
    }
}
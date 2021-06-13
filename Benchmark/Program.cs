using BenchmarkDotNet.Running;

namespace Benchmark
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}
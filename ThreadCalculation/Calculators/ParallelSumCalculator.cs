using System.Collections.Generic;
using System.Linq;

namespace ThreadCalculation.Calculators
{
    public class ParallelSumCalculator : SimpleCalculator
    {
        public ParallelSumCalculator(int[] source)
            : base(source)
        {
        }

        public override int Sum()
        {
            return Source.AsParallel().Sum();
        }
    }
}
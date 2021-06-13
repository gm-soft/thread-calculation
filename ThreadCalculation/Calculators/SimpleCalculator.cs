using System.Collections.Generic;
using System.Linq;

namespace ThreadCalculation.Calculators
{
    public class SimpleCalculator : ICalculator
    {
        protected readonly int[] Source;

        public SimpleCalculator(int[] source)
        {
            Source = source;
        }

        public virtual int Sum()
        {
            return Source.Sum();
        }
    }
}
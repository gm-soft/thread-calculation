using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadCalculation.Calculators
{
    public class MultithreadCalculator : SimpleCalculator
    {
        private int _sum;
        private readonly object _sumLocker = new ();
        private readonly int _numberThreads;
        
        public MultithreadCalculator(int[] source)
            : base(source)
        {
            _numberThreads = Environment.ProcessorCount;
        }

        public override int Sum()
        {
            _sum = 0;

            int chunkSize = Source.Length / _numberThreads;
            var threads = new List<Thread>(_numberThreads);

            for (int i = 0; i < _numberThreads; i++)
            {
                var chunkArray = new int[chunkSize];
                Array.Copy(
                    sourceArray: Source,
                    sourceIndex: i * chunkSize,
                    destinationArray: chunkArray,
                    destinationIndex: 0,
                    length: chunkSize);

                var thread = new Thread(new ParameterizedThreadStart(SumArrayInThread));
                thread.Start(chunkArray);
                threads.Add(thread);
            }
            
            threads.ForEach(x => x.Join());
            return _sum;
        }

        private void SumArrayInThread(object array)
        {
            var sum = ((int[])array).Sum();
            lock (_sumLocker)
            {
                _sum += sum;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ThreadCalculation.Calculators
{
    public class MultithreadCalculator : SimpleCalculator
    {
        private int _sum;
        private readonly object _sumLocker = new ();
        private readonly int _numberThreads;
        
        public MultithreadCalculator(IReadOnlyCollection<int> source)
            : base(source)
        {
            _numberThreads = Environment.ProcessorCount;
        }

        public override int Sum()
        {
            _sum = 0;
            var parts = Split();
            var threadList = new List<Thread>();
            
            foreach (var part in parts)
            {
                var thread = new Thread(SumArrayInThread);
                threadList.Add(thread);
                thread.Start(part);
            }

            foreach (var thread in threadList)
            {
                thread.Join();
            }

            return _sum;
        }
        
        private IReadOnlyCollection<IReadOnlyCollection<int>> Split ()
        {
            var i = 0;
            var splits = from item in Source
                group item by i++ % _numberThreads
                into part
                select part.ToArray();
            return splits.ToArray();
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
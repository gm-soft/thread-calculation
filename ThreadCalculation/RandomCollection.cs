using System;
using System.Collections;
using System.Collections.Generic;

namespace ThreadCalculation
{
    public class RandomCollection : IReadOnlyCollection<int>
    {
        private readonly int[] _source;

        public RandomCollection(int size)
        {
            _source = new int[size];
            var random = new Random();
            for (var i = 0; i < _source.Length; i++)
            {
                _source[i] = random.Next(-100, 100);
            }
        }

        public IEnumerator<int> GetEnumerator() => ((IEnumerable<int>)_source).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public int Count => _source.Length;

        public int[] ToArray() => _source;
    }
}
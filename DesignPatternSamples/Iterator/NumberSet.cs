using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public class NumberSet : IEnumerable<int>
    {
        private readonly List<int> numbers;

        public NumberSet()
        {
            numbers = new List<int>();
        }

        public int this[int index]
        {
            get => numbers[index];
            set => Add(value);
        }

        public int Count => numbers.Count;

        public void Add(int value)
        {
            if (!numbers.Contains(value))
                numbers.Add(value);
        }

        public void Remove(int value)
        {
            numbers.Remove(value);
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new NumberSetEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

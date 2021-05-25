using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public class NumberSetEnumerator : IEnumerator<int>
    {
        private readonly NumberSet parent;
        private int index;

        public NumberSetEnumerator(NumberSet parent)
        {
            this.parent = parent;
            index = -1;
        }

        public int Current => parent[index];

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            bool result = false;
            if (index < parent.Count - 1)
            {
                index++;
                result = true;
            }
            return result;
        }

        public void Reset()
        {
            index = -1;
        }

        public void Dispose()
        {
        }
    }
}

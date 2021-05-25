using System;

namespace Iterator
{
    class Program
    {
        static void Main()
        {
            var set = new NumberSet();
            set.Add(1);
            set.Add(3);
            set.Add(1);
            set.Add(8);
            set.Add(2);
            set.Add(7);

            var enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            enumerator.Reset();

            Console.ReadKey();
        }
    }
}

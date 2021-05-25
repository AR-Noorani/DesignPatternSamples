using System;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static async Task Main()
        {
            var handler = GetHandler();

            Data data = await handler.GetDataAsync(3);
            Console.WriteLine($"data.ID = {data.ID}");
            Console.WriteLine($"data.Value = {data.Value}");
            Console.WriteLine();

            data = await handler.GetDataAsync(4);
            Console.WriteLine($"data.ID = {data.ID}");
            Console.WriteLine($"data.Value = {data.Value}");
            Console.WriteLine();

            data = await handler.GetDataAsync(3);
            Console.WriteLine($"data.ID = {data.ID}");
            Console.WriteLine($"data.Value = {data.Value}");
            Console.WriteLine();

            Console.ReadKey();
        }

        static Handler GetHandler()
        {
            var h1 = new DefaultHandler();
            var h2 = new DbHandler(h1);
            var h3 = new CacheHandler(h2);
            return h3;
        }
    }
}

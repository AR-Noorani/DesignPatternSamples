using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class CacheHandler : Handler
    {
        private readonly ConcurrentDictionary<int, Data> cache;

        public CacheHandler(Handler successor) : base(successor)
        {
            cache = new ConcurrentDictionary<int, Data>();
        }

        public override async Task<Data> GetDataAsync(int id)
        {
            if (cache.ContainsKey(id))
            {
                return cache[id];
            }
            else
            {
                var result = await successor.GetDataAsync(id);

                cache.TryAdd(id, result);

                return result;
            }
        }
    }
}

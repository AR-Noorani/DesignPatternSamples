using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class DefaultHandler : Handler
    {
        public DefaultHandler() : base(null) { }

        public override async Task<Data> GetDataAsync(int id)
        {
            return new Data();
        }
    }
}

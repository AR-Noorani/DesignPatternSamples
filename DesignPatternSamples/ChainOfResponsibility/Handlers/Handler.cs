using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler successor;

        public Handler(Handler successor)
        {
            this.successor = successor;
        }

        public abstract Task<Data> GetDataAsync(int id);
    }
}

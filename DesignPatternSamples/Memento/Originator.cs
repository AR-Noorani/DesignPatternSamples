using System;

namespace Memento
{
    public class Originator
    {
        private class Memento : IMemento
        {
            public string State1 { get; }
            public string State2 { get; }

            public Memento(string state1, string state2)
            {
                State1 = state1;
                State2 = state2;
            }
        }

        private string state1;
        public string state2;

        public Originator()
        {
        }

        public Originator(string state1, string state2)
        {
            this.state1 = state1;
            this.state2 = state2;
        }

        public IMemento Backup()
        {
            return new Memento(state1, state2);
        }

        public void Restore(IMemento memento)
        {
            if (memento is not Memento)
                throw new ArgumentException("memento argument is not valid.");

            var mem = (Memento)memento;
            state1 = mem.State1;
            state2 = mem.State2;
        }
    }
}

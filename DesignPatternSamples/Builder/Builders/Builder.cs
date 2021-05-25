namespace Builder
{
    public abstract class ComputerBuilder
    {
        protected Computer Computer;

        public ComputerBuilder(string model)
        {
            Computer = new Computer { Model = model };
        }

        public abstract void BuildCPU();
        public abstract void BuildRAM();

        public Computer GetProduct()
        {
            return Computer;
        }
    }
}

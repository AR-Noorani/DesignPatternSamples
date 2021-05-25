namespace Builder
{
    public class Director
    {
        private ComputerBuilder _computerBuilder;

        public void SetBuilder(ComputerBuilder builder)
        {
            _computerBuilder = builder;
        }

        public void Construct()
        {
            _computerBuilder.BuildCPU();
            _computerBuilder.BuildRAM();
        }
    }
}

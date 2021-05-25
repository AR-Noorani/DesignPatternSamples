namespace Builder
{
    public class Corei5Builder : ComputerBuilder
    {
        public Corei5Builder() : base("Corei5") { }

        public override void BuildCPU()
        {
            Computer.CPU = "AMD 1";
        }

        public override void BuildRAM()
        {
            Computer.RAM = "8 GB";
        }
    }
}

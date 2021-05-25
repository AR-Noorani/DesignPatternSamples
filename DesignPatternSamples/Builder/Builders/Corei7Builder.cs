namespace Builder
{
    public class Corei7Builder : ComputerBuilder
    {
        public Corei7Builder() : base("Corei7") { }

        public override void BuildCPU()
        {
            Computer.CPU = "AMD 2";
        }

        public override void BuildRAM()
        {
            Computer.RAM = "16 GB";
        }
    }
}

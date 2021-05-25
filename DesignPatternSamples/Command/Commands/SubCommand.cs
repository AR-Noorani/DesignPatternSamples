namespace Command
{
    public class SubCommand : CalcCommand
    {
        public SubCommand() : base("Subtract") { }

        public override void Execute()
        {
            base.Execute();
            Core.Subtract(Operand);
        }
    }
}

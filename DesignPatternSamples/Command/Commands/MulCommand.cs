namespace Command
{
    public class MulCommand : CalcCommand
    {
        public MulCommand() : base("Multiply") { }

        public override void Execute()
        {
            base.Execute();
            Core.Multiply(Operand);
        }
    }
}

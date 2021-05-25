namespace Command
{
    public class DivCommand : CalcCommand
    {
        public DivCommand() : base("Divide") { }

        public override void Execute()
        {
            base.Execute();
            Core.Divide(Operand);
        }
    }
}

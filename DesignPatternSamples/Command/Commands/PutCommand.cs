namespace Command
{
    public class PutCommand : CalcCommand
    {
        public PutCommand() : base("Put") { }

        public override void Execute()
        {
            base.Execute();
            Core.Put(Operand);
        }
    }
}

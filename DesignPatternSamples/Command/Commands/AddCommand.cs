namespace Command
{
    public class AddCommand : CalcCommand
    {
        public AddCommand() : base("Add") { }

        public override void Execute()
        {
            base.Execute();
            Core.Add(Operand);
        }
    }
}

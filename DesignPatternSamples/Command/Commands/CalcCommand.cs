namespace Command
{
    public abstract class CalcCommand
    {
        protected readonly CalculatorCore Core;

        public string Name { get; protected set; }
        public double OldValue { get; protected set; }
        public double Operand { get; protected set; }
        public double CurrentValue => Core.CurrentValue;

        public CalcCommand(string name)
        {
            Name = name;
            Core = ServiceLocator.GetService<CalculatorCore>();
        }

        public void SetOperand(double operand)
        {
            Operand = operand;
        }

        public virtual void Execute()
        {
            OldValue = Core.CurrentValue;
        }

        public virtual void Unexecute()
        {
            Core.Put(OldValue);
        }
    }
}

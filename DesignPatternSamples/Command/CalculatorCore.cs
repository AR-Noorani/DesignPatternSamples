namespace Command
{
    public class CalculatorCore
    {
        public double CurrentValue { get; private set; }

        public void Put(double value)
        {
            CurrentValue = value;
        }

        public void Add(double value)
        {
            CurrentValue += value;
        }

        public void Subtract(double value)
        {
            CurrentValue -= value;
        }

        public void Multiply(double value)
        {
            CurrentValue *= value;
        }

        public void Divide(double value)
        {
            CurrentValue /= value;
        }
    }
}
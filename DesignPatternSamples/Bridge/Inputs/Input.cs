namespace Bridge
{
    public abstract class Input
    {
        private readonly Output output = OutputImp.Get();

        public string Value { get; set; }

        public void Print()
        {
            output.Print(Value);
        }
    }
}

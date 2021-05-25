namespace Builder
{
    public class Computer
    {
        public string Model { get; set; }
        public string CPU { get; set; }
        public string RAM { get; set; }

        public override string ToString()
        {
            return $"Model = {Model}; CPU = {CPU}; RAM = {RAM}";
        }
    }
}

namespace Interpreter
{
    public class BoolExpression : LogicalExpression
    {
        private bool _value;

        public BoolExpression(bool value)
        {
            _value = value;
        }

        public override bool Interpret()
        {
            return _value;
        }
    }
}

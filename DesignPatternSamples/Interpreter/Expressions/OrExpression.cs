namespace Interpreter
{
    public class OrExpression : LogicalExpression
    {
        public LogicalExpression Left { get; }
        public LogicalExpression Right { get; }

        public OrExpression(LogicalExpression left, LogicalExpression right)
        {
            Left = left;
            Right = right;
        }

        public override bool Interpret()
        {
            return Left.Interpret() || Right.Interpret();
        }
    }
}

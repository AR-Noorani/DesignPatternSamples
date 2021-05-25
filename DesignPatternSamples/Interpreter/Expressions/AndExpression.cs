namespace Interpreter
{
    public class AndExpression : LogicalExpression
    {
        public LogicalExpression Left { get; }
        public LogicalExpression Right { get; }

        public AndExpression(LogicalExpression left, LogicalExpression right)
        {
            Left = left;
            Right = right;
        }

        public override bool Interpret()
        {
            return Left.Interpret() && Right.Interpret();
        }
    }
}

namespace Interpreter
{
    public class NotExpression : LogicalExpression
    {
        public LogicalExpression Expression { get; }

        public NotExpression(LogicalExpression expression)
        {
            Expression = expression;
        }

        public override bool Interpret()
        {
            return !Expression.Interpret();
        }
    }
}

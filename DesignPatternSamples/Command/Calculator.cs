using System.Collections.Generic;

namespace Command
{
    public class Calculator
    {
        private readonly Stack<CalcCommand> stack = new();

        public double Value => stack.TryPeek(out var lastCommand) ? lastCommand.CurrentValue : 0;

        public void ExecuteCommand<T>(double operand) where T : CalcCommand, new()
        {
            var command = new T();
            command.SetOperand(operand);
            stack.Push(command);
            command.Execute();
        }

        public void Undo()
        {
            stack.Pop().Unexecute();
        }
    }
}

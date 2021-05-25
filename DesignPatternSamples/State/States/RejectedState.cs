using System;

namespace State
{
    public class RejectedState : LeaveRequestState
    {
        public override void ReturnToRegistered(LeaveRequest request)
        {
            request.State = new RegisteredState();
        }

        public override void Operation(LeaveRequest request)
        {
            Console.WriteLine($"LeaveRequest with rejected State ===> Operation.");
        }
    }
}

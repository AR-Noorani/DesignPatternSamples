using System;

namespace State
{
    public class RegisteredState : LeaveRequestState
    {
        public override void Confirm(LeaveRequest request)
        {
            request.State = new ConfirmedState();
        }

        public override void Reject(LeaveRequest request)
        {
            request.State = new RejectedState();
        }

        public override void Operation(LeaveRequest request)
        {
            Console.WriteLine($"LeaveRequest with registered State ===> Operation.");
        }
    }
}

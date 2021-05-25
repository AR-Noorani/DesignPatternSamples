using System;

namespace State
{
    public class LeaveRequest
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public LeaveRequestState State { get; set; }

        public LeaveRequest()
        {
            State = new RegisteredState();
        }

        public void Confirm()
        {
            State.Confirm(this);
        }

        public void Reject()
        {
            State.Reject(this);
        }

        public void ReturnToRegistered()
        {
            State.ReturnToRegistered(this);
        }

        public void Operation()
        {
            State.Operation(this);
        }
    }
}

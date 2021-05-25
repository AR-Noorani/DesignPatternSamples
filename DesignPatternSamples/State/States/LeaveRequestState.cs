namespace State
{
    public abstract class LeaveRequestState
    {
        public virtual void Confirm(LeaveRequest request) { }
        public virtual void Reject(LeaveRequest request) { }
        public virtual void ReturnToRegistered(LeaveRequest request) { }

        public abstract void Operation(LeaveRequest request);
    }
}

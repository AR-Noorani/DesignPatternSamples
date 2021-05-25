using System;

namespace State
{
    class Program
    {
        static void Main()
        {
            var request = new LeaveRequest
            {
                ID = 1,
                EmployeeID = 1,
                From = DateTime.Now,
                To = DateTime.Now.AddHours(2)
            };
            request.Operation();

            request.Confirm();
            request.Operation();

            request.ReturnToRegistered();
            request.Operation();

            request.Reject();
            request.Operation();

            Console.ReadKey();
        }
    }
}

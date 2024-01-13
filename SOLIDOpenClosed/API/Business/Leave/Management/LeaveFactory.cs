using API.Business.Leave.Management.LeaveOperators;
using API.Business.Leave.Models;
using API.Data.Entities;

namespace API.Business.Leave.Management
{
    public class LeaveFactory
    {
        public void CreateLeave(CreateLeaveModel request, User user)
        {
            var leaveOperator = GetOperator(request.LeaveType);
            leaveOperator.Create(request, user);
        }

        private LeaveOpeator GetOperator(LeaveType leaveType)
        {
            return leaveType switch
            {
                LeaveType.Annual => new AnnualLeaveOperator(),
                LeaveType.Excused => new ExcusedLeaveOperator(),
                LeaveType.Sick => new SickLeaveOperator(),
                _ => throw new NotImplementedException(),
            };
        }
    }
}

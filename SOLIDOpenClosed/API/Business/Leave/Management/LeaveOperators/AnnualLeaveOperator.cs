using API.Business.Leave.Models;
using API.Data.Entities;

namespace API.Business.Leave.Management.LeaveOperators
{
    public class AnnualLeaveOperator : LeaveOpeator
    {
        public override void Create(CreateLeaveModel request, User user)
        {
            CheckLeaveRight(user.LeaveInformations.AnnualLeave, request.RequestedDayCount);
            user.LeaveInformations.AnnualLeave.UsedDays += request.RequestedDayCount;
        }
    }
}

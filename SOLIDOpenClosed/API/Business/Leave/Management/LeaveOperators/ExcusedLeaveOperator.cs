using API.Business.Leave.Models;
using API.Data.Entities;

namespace API.Business.Leave.Management.LeaveOperators
{
    public class ExcusedLeaveOperator : LeaveOpeator
    {
        public override void Create(CreateLeaveModel request, User user)
        {
            CheckLeaveRight(user.LeaveInformations.ExcusedLeave, request.RequestedDayCount);

            user.LeaveInformations.ExcusedLeave.UsedDays += request.RequestedDayCount;
            user.LeaveExpenseForSalay += request.RequestedDayCount * user.DailySalary;
        }
    }
}

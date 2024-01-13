using API.Business.Leave.Models;
using API.Data.Entities;

namespace API.Business.Leave.Management.LeaveOperators
{
    public abstract class LeaveOpeator
    {
        public abstract void Create(CreateLeaveModel request, User user);

        protected void CheckLeaveRight(Data.Entities.Leave leave, int requestedDayCount)
        {
            var availableExcusedLeaveRights =
                leave.TotalLeaveRights - leave.UsedDays;
            if (availableExcusedLeaveRights < requestedDayCount)
                throw new Exception("NotAcceptable");
        }
    }
}

using Leave.API.Data.Entities;

namespace Leave.API.Business.Leave.Models.LeaveTypes
{
    public class ExcusedLeave : BaseLeave
    {
        public ExcusedLeave(int requestedDayCount) : base(requestedDayCount)
        {

        }

        public override void ProcessLeave(UserEntity user)
        {
            CheckLeaveRight(user.LeaveInformations.ExcusedLeave, RequestedDayCount);
            user.LeaveInformations.AnnualLeave.UsedDays += RequestedDayCount;
        }
    }
}

using Leave.API.Data.Entities;

namespace Leave.API.Business.Leave.Models.LeaveTypes
{
    public class AnnualLeave : BaseLeave
    {
        public AnnualLeave(int requestedDayCount) : base(requestedDayCount)
        {

        }

        public override void ProcessLeave(UserEntity user)
        {
            CheckLeaveRight(user.LeaveInformations.AnnualLeave, RequestedDayCount);
            user.LeaveInformations.AnnualLeave.UsedDays += RequestedDayCount;
        }
    }
}

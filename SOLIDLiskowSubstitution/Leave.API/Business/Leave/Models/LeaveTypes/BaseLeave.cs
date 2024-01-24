using Leave.API.Data.Entities;

namespace Leave.API.Business.Leave.Models.LeaveTypes
{
    public abstract class BaseLeave
    {
        public BaseLeave(int requestedDayCount)
        {
            RequestedDayCount = requestedDayCount;
        }

        protected void CheckLeaveRight(LeaveEntity leave, int requestedDayCount)
        {
            var availableExcusedLeaveRights =
                leave.TotalLeaveRights - leave.UsedDays;
            if (availableExcusedLeaveRights < requestedDayCount)
                throw new Exception("NotAcceptable");
        }

        public int RequestedDayCount { get; set; }
        public abstract void ProcessLeave(UserEntity user);
    }
}

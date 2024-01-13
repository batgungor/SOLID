namespace API.Business.Leave.Models
{
    public class CreateLeaveModel
    {
        public string PersonId { get; set; }
        public int RequestedDayCount { get; set; }
        public LeaveType LeaveType { get; set; }
    }
}

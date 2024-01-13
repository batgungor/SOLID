using API.Business.Leave.Management;
using API.Business.Leave.Models;
using API.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/leave")]
    public class LeaveController : Controller
    {
        private readonly MockDataBase _database;
        public LeaveController()
        {
            _database = new MockDataBase();
        }
        [HttpPost]
        public IActionResult CreateLeave([FromBody] CreateLeaveModel request)
        {
            var user = _database.GetUser(request.PersonId);
            if (user == null) return NotFound();

            var leaveFactory = new LeaveFactory();
            leaveFactory.CreateLeave(request, user);

            /*
            var userLeaveInformations = user.LeaveInformations;
            switch (request.LeaveType)
            {
                case LeaveType.Annual:
                    var availableAnnualLeaveRights = userLeaveInformations.AnnualLeave.TotalLeaveRights - userLeaveInformations.AnnualLeave.UsedDays;
                    if (availableAnnualLeaveRights <= request.RequestedDayCount)
                        return StatusCode(StatusCodes.Status406NotAcceptable);

                    userLeaveInformations.AnnualLeave.UsedDays += request.RequestedDayCount;
                    break;
                case LeaveType.Excused:
                    var availableExcusedLeaveRights = userLeaveInformations.ExcusedLeave.TotalLeaveRights - userLeaveInformations.ExcusedLeave.UsedDays;
                    if (availableExcusedLeaveRights <= request.RequestedDayCount)
                        return StatusCode(StatusCodes.Status406NotAcceptable);

                    userLeaveInformations.ExcusedLeave.UsedDays += request.RequestedDayCount;
                    user.LeaveExpenseForSalay += request.RequestedDayCount * user.DailySalary;
                    break;
            }
            */
            return Ok(user);
        }
    }
}
